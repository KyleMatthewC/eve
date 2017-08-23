using Eve.DataClass;
using Eve.Mock_Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Models
{
    public class UserAccountModel
    {
        private List<UserAccount> users = new UserAccountMockData().InitializeUserMockData();

        public UserAccount GetUser(string username, string password)
        {
            for(int ctr = 0; ctr < users.Count; ctr++)
            {
                if (users[ctr].username == username && users[ctr].password == password)
                    return users[ctr];
            }

            return null;
        }
    }
}
