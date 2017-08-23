using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class JobRole
    {
        public int jobRoleID { get; set; }
        public int jobRoleLevel { get; set; }
        public string jobRole { get; set; }

        public JobRole(int ID, int level, string role)
        {
            this.jobRoleID = ID;
            this.jobRoleLevel = level;
            this.jobRole = role;
        }
    }
}
