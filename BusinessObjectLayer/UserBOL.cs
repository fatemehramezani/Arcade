using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class UserBOL
    {
        private short? userId;
        private string userName;
        private string password;
        private string newPassword;
        private string description;
        
        public short? UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string NewPassword
        {
            get { return this.newPassword; }
            set { this.newPassword = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public UserBOL() { }
        public UserBOL(short? UserID, string UserName, string Password, string NewPassword, string Description)
        {
            this.userId = UserID;
            this.userName = UserName;
            this.password = Password;
            this.newPassword = NewPassword;
            this.description = Description;
        }
    }
}
