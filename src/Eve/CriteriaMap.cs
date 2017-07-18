using System;
using System.Collections.Generic;
using System.Text;

namespace Eve
{
    public class CriteriaMap
    {
        private Dictionary<Criteria, string> criteriaDict = new Dictionary<Criteria, string>();

        public CriteriaMap()
        {
            criteriaDict = new Dictionary<Criteria, string>();
        }

        public void AddCriteriaMessage(Criteria criteria, string message)
        {
            criteriaDict.Add(criteria, message);
        }

        public string GetCriteriaMessage(Criteria criteria)
        {
            string message;
            if (criteriaDict.TryGetValue(criteria, out message))
            {
                return message;
            }
            return null;
        }

    }
}
