using Eve.DataClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class JobRoleMockData
    {
        public List<JobRole> InitializeJobRolesMockData()
        {
            List<JobRole> roles = new List<JobRole>();

            roles.Add(new JobRole(0, 12, "Individual Contributor"));
            roles.Add(new JobRole(1, 10, "Individual Contributor"));

            return roles;
        }
    }
}
