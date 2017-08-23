using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class Storage
    {
        private CriteriaMap criteriaMap;

        public Storage()
        {
            Filler filler = new Filler();
            criteriaMap = filler.FillCriteriaMap();
        }

        public string GetMessage(Criteria criteria)
        {
            string message = criteriaMap.GetCriteriaMessage(criteria);

            if (message != null)
            {
                return message;
            }
            return "N/A";
        }
    }
}
