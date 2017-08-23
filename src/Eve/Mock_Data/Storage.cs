using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            if (criteria != null)
            {
                List<LineResponse> list = criteriaMap.GetCriteriaResponce(criteria);
                string message = "";
                if (list != null) {
                    for (int i = 0; i < list.Capacity; i++)
                    {
                        LineResponse responce = list.ElementAt(i);
                        message += responce.Message;
                    }
                }
                return message;
            }
            return "N/A";
        }
    }
}
