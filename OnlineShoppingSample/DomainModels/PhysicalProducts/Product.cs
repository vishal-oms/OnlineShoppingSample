using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.DomainModels;

namespace WebApplication4
{

    public abstract class PhysicalProduct : IEntity
    {
        public string Name { get; set; }
        public abstract string GenerateSlip();
    }

    public class ConcreteProduct : PhysicalProduct, IAgentContract
    {
        private readonly IAgentContract _agentContract;
        public ConcreteProduct(IAgentContract agentContract)
        {
            _agentContract = agentContract;
        }
        public new string Name { get; set; }

        public override string GenerateSlip()
        {
            return "Slip generated...";
        }
        public string Commission()
        {
            return _agentContract.Commission();
        }
    }

}
