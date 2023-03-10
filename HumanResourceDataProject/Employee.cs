using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceDataProject
{
    public class Employee : HumanResource
    {
        private List<Employee> subordinates;
        public List<Employee> Subordinates
        {
            get { return new List<Employee>(subordinates); }
        }

        public Employee(string name, string username, string password, DateTime dateStarted) : base(name, username, password, dateStarted)
        {
            this.subordinates = new List<Employee>();
        }

        public bool IsSubordinate(Employee employee)
        {
            foreach (Employee subordinate in this.subordinates)
            {
                if(subordinate.IsSubordinate(employee)) return true;
            }
            return false;
        }

        public bool AddSubordinate(Employee employee)
        {
            if (!this.IsSubordinate(employee))
            {
                this.subordinates.Add(employee);
                return true;
            }
            return false;
        }

        public void RemoveSubordinate(Employee employee)
        {
            this.subordinates.Remove(employee);
        }
    }
}
