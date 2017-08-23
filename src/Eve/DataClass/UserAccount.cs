using System;

namespace Eve.DataClass
{
    public class UserAccount
    {
        public long accountId { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public UserRole userRole{ get; set; }

        public UserAccount(long id, string username, string password, UserRole userRole)
        {
            this.accountId = id;
            this.username = username;
            this.password = password;
            this.userRole = userRole;
        }
    }
}
