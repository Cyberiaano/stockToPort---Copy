using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using StockToPort;

namespace stockToPort
{
    class StockToPortNodeManager : CustomNodeManager2
    {
        private BeltConveyorState conveyor1;
        private CancellationTokenSource cancellationTokenSource;
        private Random random = new Random();

        public StockToPortNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = StockToPort.Namespaces.STP;
            namespaceUrls[1] = StockToPort.Namespaces.STP + "/Instance";
            SetNamespaces(namespaceUrls);

            m_configuration = configuration.ParseExtension<StockToPortConfiguration>();
            if (m_configuration == null)
            {
                m_configuration = new StockToPortConfiguration();
            }

            cancellationTokenSource = new CancellationTokenSource();
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "xxxxxxxxxxxxxxxxxxxxxxxxxStockToPort.PredefinedNodes.uanodes",
                typeof(StockToPortNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(
                    new NodeId(StockToPort.Objects.BeltConveyor1, NamespaceIndexes[0]),
                    typeof(BaseObjectState));

                conveyor1 = new BeltConveyorState(null);
                conveyor1.Create(SystemContext, passiveNode);

                AddPredefinedNode(SystemContext, conveyor1);

                Task.Run(() => SimulateConveyorData(cancellationTokenSource.Token));
            }
        }

        private void SimulateConveyorData(CancellationToken token)
        {
            Random random = new Random();
            // Initial values
            double beltSpeed = 2.5; // Start at mid-range (m/s)
            double load = 500.0; // Start at mid-range (kg)
            double alignment = 0.0; // Start centered (mm)
            double vibration = 5.0; // Start at mid-range (m/s²)
            double motorCurrent = 30.0; // Start at mid-range (A)
            double motorVoltage = 220.0; // Start at mid-range (V)
            double motorTemp = 40.0; // Start at mid-range (°C)

            // Target values that change periodically
            double targetBeltSpeed = beltSpeed;
            double targetLoad = load;
            double targetAlignment = alignment;
            double targetVibration = vibration;
            double targetMotorCurrent = motorCurrent;
            double targetMotorVoltage = motorVoltage;
            double targetMotorTemp = motorTemp;

            int changeTargetCounter = 0;
            const int TARGET_CHANGE_INTERVAL = 10; // Change targets every 10 seconds

            while (!token.IsCancellationRequested)
            {
                lock (Lock)
                {
                    // Periodically update target values for gradual trends
                    if (changeTargetCounter >= TARGET_CHANGE_INTERVAL)
                    {
                        targetBeltSpeed = 0.5 + (random.NextDouble() * 4.5); // 0.5 to 5.0 m/s
                        targetLoad = random.NextDouble() * 1000; // 0 to 1000 kg
                        targetAlignment = -10 + (random.NextDouble() * 20); // -10 to 10 mm
                        targetVibration = random.NextDouble() * 10; // 0 to 10 m/s²
                        targetMotorCurrent = 10 + (random.NextDouble() * 40); // 10 to 50 A
                        targetMotorVoltage = 200 + (random.NextDouble() * 40); // 200 to 240 V
                        targetMotorTemp = 20 + (random.NextDouble() * 60); // 20 to 80 °C
                        changeTargetCounter = 0;
                    }
                    changeTargetCounter++;

                    // Smoothly adjust values toward targets with small random noise
                    beltSpeed = SmoothValue(beltSpeed, targetBeltSpeed, 0.1, random, 0.05); // Max 0.1 m/s change per second
                    load = SmoothValue(load, targetLoad, 50.0, random, 10.0); // Max 50 kg change per second
                    alignment = SmoothValue(alignment, targetAlignment, 0.5, random, 0.1); // Max 0.5 mm change per second
                    vibration = SmoothValue(vibration, targetVibration, 0.2, random, 0.05); // Max 0.2 m/s² change per second

                    // Motor current depends on load (higher load → higher current)
                    targetMotorCurrent = 10 + (targetLoad / 1000 * 40); // Scale current with load
                    motorCurrent = SmoothValue(motorCurrent, targetMotorCurrent, 2.0, random, 0.5); // Max 2 A change

                    // Motor voltage with slight fluctuations
                    motorVoltage = SmoothValue(motorVoltage, targetMotorVoltage, 1.0, random, 0.2); // Max 1 V change

                    // Motor temperature depends on current (higher current → higher temp)
                    targetMotorTemp = 20 + (motorCurrent / 50 * 60); // Scale temp with current
                    motorTemp = SmoothValue(motorTemp, targetMotorTemp, 1.0, random, 0.2); // Max 1 °C change

                    // Update sensor values
                    conveyor1.BeltSpeedSensor.Measurement.Value = Math.Round(beltSpeed, 2);
                    conveyor1.BeltLoadSensor.Measurement.Value = Math.Round(load, 2);
                    conveyor1.BeltAlignmentSensor.Measurement.Value = Math.Round(alignment, 2);
                    conveyor1.VibrationSensor.Measurement.Value = Math.Round(vibration, 2);
                    conveyor1.MotorCurrentSensor.Measurement.Value = Math.Round(motorCurrent, 2);
                    conveyor1.MotorVoltageSensor.Measurement.Value = Math.Round(motorVoltage, 2);
                    conveyor1.MotorTemperatureSensor.Measurement.Value = Math.Round(motorTemp, 2);

                    // Clear change masks to notify OPC UA server
                    conveyor1.BeltSpeedSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.BeltLoadSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.BeltAlignmentSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.VibrationSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.MotorCurrentSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.MotorVoltageSensor.Measurement.ClearChangeMasks(SystemContext, false);
                    conveyor1.MotorTemperatureSensor.Measurement.ClearChangeMasks(SystemContext, false);
                }

                // Randomize sleep interval slightly for realism (900-1100 ms)
                Thread.Sleep(900 + random.Next(0, 201));
            }
        }

        // Helper method to smoothly transition values with noise
        private double SmoothValue(double current, double target, double maxChange, Random random, double noiseAmplitude)
        {
            // Move toward target by a fraction of the max change
            double delta = target - current;
            double change = Math.Max(-maxChange, Math.Min(maxChange, delta * 0.2)); // 20% of delta, capped at maxChange
            double newValue = current + change;

            // Add small random noise
            double noise = (random.NextDouble() - 0.5) * 2 * noiseAmplitude; // Noise between -noiseAmplitude and +noiseAmplitude
            newValue += noise;

            // Clamp to valid range
            return Math.Max(Math.Min(newValue, target + noiseAmplitude), target - noiseAmplitude);
        }

        public override void DeleteAddressSpace()
        {
            cancellationTokenSource.Cancel();
            base.DeleteAddressSpace();
        }

        private StockToPortConfiguration m_configuration;
    }
}