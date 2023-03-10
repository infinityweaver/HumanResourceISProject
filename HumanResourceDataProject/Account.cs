using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceDataProject
{
    [Serializable]
    public class Account
    {
        private static int ACCOUNT_COUNTER = 0;

        public int AccountID { get; private set; }
        public string Username { get; private set; }
        private string password;
        private bool isActive;
        public bool IsActive { 
            get { return isActive; }
        }

        public Account(string username, string password)
        {
            this.Username = username ?? throw new ArgumentNullException("username must not be null");
            this.password = password ?? throw new ArgumentNullException("password must not be null");
            this.isActive = true;
            this.AccountID = Account.ACCOUNT_COUNTER++;
        }

        public bool LogIn(string username, string password)
        {
            return isActive && username.Equals(this.Username) && password.Equals(this.password);
        }

        public bool Deactivate(string username, string password) 
        {
            if (LogIn(username, password))
            {
                this.isActive = false;
                return true;
            }
            return false;
        }

        public bool Reactivate(string username, string password)
        {
            if(!IsActive && username.Equals(this.Username) && password.Equals(this.password))
            {
                this.isActive = true;
                return true;
            }
            return false;
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if(this.IsActive && username.Equals(this.Username) && oldPassword.Equals(this.password))
            {
                this.password = newPassword;
                return true;
            }
            return false;
        }
    }
}
