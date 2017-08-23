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

        // custom overrides so same criterias are equal and return the same hashcodes
        public override bool Equals(object obj)
        {
            Criteria criteria = obj as Criteria;
            if (obj == null)
            {
                return false;
            }
            if (criteria.SpecificRole == SpecificRole && criteria.TeamRole == TeamRole)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash;
            Int32.TryParse(SpecificRole.ToString() + TeamRole.ToString(), out hash);
            return hash;
        }
    }
}
