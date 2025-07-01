using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockToPort
{
    class StockToPortServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the node manager");
            List<INodeManager> nodeManagers = new List<INodeManager>();
            nodeManagers.Add(new StockToPortNodeManager(server, configuration));
            return new MasterNodeManager(server,configuration,null,nodeManagers.ToArray());
        }
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties serverProperties = new ServerProperties();
            serverProperties.ManufacturerName = "Monir";
            serverProperties.ProductName = " Stock to Port Plant";
            serverProperties.ProductUri = "http://example.com/StockToPort";
            serverProperties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            serverProperties.BuildNumber = Utils.GetAssemblyBuildNumber();
            serverProperties.BuildDate = Utils.GetAssemblyTimestamp();

            return serverProperties;
        }

    }
}
