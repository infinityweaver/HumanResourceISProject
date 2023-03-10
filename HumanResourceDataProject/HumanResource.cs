using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceDataProject
{
    [Serializable]
    public abstract class HumanResource
    {
        public static int MINIMUM_NUMBER_OF_DAYS_WORKED = 15;
        public Account Account {  get; private set; }
        public string Name { get; set; }
        public bool IsActive { get; private set; }
        private readonly List<DateTime> datesStarted;
        private readonly List<DateTime> datesResigned;
        public DateTime DateStarted { get { return datesStarted[^1]; } }
        public DateTime? DateResigned { get { return !this.IsActive ? datesResigned[datesResigned.Count - 1] : null; } }
        
        public HumanResource(string name, string username, string password, DateTime dateStarted)
        {
            this.Name = name;
            this.Account = new Account(username, password);
            this.IsActive = true;
            this.datesStarted = new List<DateTime>();
            this.datesStarted.Add(dateStarted);
            this.datesResigned = new List<DateTime>();
        }

        public bool Resigned(DateTime date)
        {
            if(date >= this.DateStarted.AddDays((int)HumanResource.MINIMUM_NUMBER_OF_DAYS_WORKED))
            {
                this.datesResigned.Add(date);
                this.IsActive = false;
                return true;
            }
            return false;
        }

        public bool Rehired(DateTime date)
        {
            if (this.DateResigned != null && date > this.DateResigned)
            {
                this.datesStarted.Add(date);
                this.IsActive = true;
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && ((obj is HumanResource && base.Equals(obj)) || (obj is Account && ((Account)obj).Equals(this.Account)));
        }

        public override int GetHashCode()
        {
            return this.Account.AccountID;
        }
    }
}
