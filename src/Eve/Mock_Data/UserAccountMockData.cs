using Eve.DataClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class UserAccountMockData
    {
        public List<UserAccount> InitializeUserMockData()
        {
            List<UserAccount> users = new List<UserAccount>();

            users.Add(new UserAccount(0, "kylechua@navitaire.com", "123456", UserRole.Employee));
            users.Add(new UserAccount(1, "dontungala", "456789", UserRole.Supervisor));
            users.Add(new UserAccount(2, "Marcv", "789123", UserRole.Admin));

            return users;
        }
    }
}
