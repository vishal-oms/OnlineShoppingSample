using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public interface IAgentContract
    {
        public string Name { get; set; }
        string Commission();
    }
    public abstract class Agent : IAgentContract
    {
        public string Name { get; set; }
        public abstract string Commission();
    }
    public class ConcreteAgent : Agent
    {
        public new string Name { get; set; }

        public override string Commission()
        {
            return "Commission generated...";
        }
    }

}
