using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public interface IEMail
    {
        string SendEmail();
    }

    public abstract class EMail : IEMail
    {
        public abstract string SendEmail();
    }
    public class ConcreteEMail : EMail
    {
        public override string SendEmail()
        {
            ThirdPartySender_One obj1 = new ThirdPartySender_One();
            obj1.SendEmail();
            return "Email sent...";
        }
    }

    public class ThirdPartySender_One : EMail
    { 
        public override string SendEmail()
        {
            return "Email sent by Provider One...";
        }
    }
    public class ThirdPartySender_Two : EMail
    {
        public override string SendEmail()
        {
            return "Email sent Provider Two...";
        }
    }
}
