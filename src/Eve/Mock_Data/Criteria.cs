using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class Criteria
    {
        public SpecificRole SpecificRole { get; set; }
        public TeamRole TeamRole { get; set; }

        public Criteria(SpecificRole specificRole, TeamRole teamRole)
        {
            SpecificRole = specificRole;
            TeamRole = teamRole;
        }
    }
}
