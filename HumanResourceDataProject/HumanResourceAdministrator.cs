using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceDataProject
{
    public class HumanResourceAdministrator
    {
        public Account Account { get; set; }

        public HumanResourceAdministrator()
        {
            this.Account = new Account("admin", "admin");
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is HumanResourceAdministrator hr && hr.Account.Equals(this.Account);
        }

        public override int GetHashCode()
        {
            return this.Account.AccountID;
        }
    }
}
