using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Services;

namespace WebApplication4.DomainModels
{
    interface IUpgradeMember
    {
        string UpgradeMember();
    }
    public abstract class Member : IEMail, IEntity
    {
        public string Name { get; set; }

        public abstract string ActivateMember();

        public abstract string SendEmail();
    }
    public class ConcreteMember : Member, IEMail, IUpgradeMember, IEntity
    {
        private readonly IEMail _email;
        public ConcreteMember(IEMail email)
        {
            _email = email;
        }
        public new string Name { get; set; }

        public override string ActivateMember()
        {
            return "Member activated...";
        }

        public override string SendEmail()
        {
            return _email.SendEmail();
        }

        public string UpgradeMember()
        {
            return "Member updated...";
        }
    }

}
