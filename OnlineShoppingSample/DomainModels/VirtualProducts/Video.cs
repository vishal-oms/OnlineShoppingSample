using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.DomainModels
{
    public interface IVideo : IEntity
    {
        public new string Name { get; set; }
        public abstract string GeneratePackagingSlip();
    }
    public interface IVideoTypes
    {
        public bool IsLearningVideo { get; set; }
    }
    public class ConcreteVideo : IVideo, IVideoTypes
    {
        public string Name { get; set; }
        public bool IsLearningVideo { get { return true; } set { } }

        public string GeneratePackagingSlip()
        {
            if(IsLearningVideo)
            {
                //  Logic to add learing video
            }
            return "Packaging Slip generated...";
        }
    }

}
