using StockToPort;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace stockToPort
{
    [DataContract(Namespace = Namespaces.STP)]
    public class StockToPortConfiguration
    {
        public StockToPortConfiguration()
        {
            Initialize();
        }
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
        private void Initialize()
        {
        }

    }
}