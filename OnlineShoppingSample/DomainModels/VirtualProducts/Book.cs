using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.DomainModels
{
    public abstract class EProduct : IEntity
    {
        public string Name { get; set; }
      
    }

    public class Book : EProduct, IAgentContract
    {
        private readonly IAgentContract _agentContract;
        public Book(IAgentContract agentContract)
        {
            _agentContract = agentContract;
        }
        public new string Name { get; set; }

        public string GenerateDulpicateSlip()
        {
            return "Duplicate Slip generated...";
        }
        public string Commission()
        {
            return _agentContract.Commission();
        }
    }
}
