using System;
using System.Collections.Generic;
using System.Text;

namespace Eve
{
    public class CriteriaMap
    {
        private Dictionary<Criteria, List<LineResponse>> criteriaDict;

        public CriteriaMap()
        {
            criteriaDict = new Dictionary<Criteria, List<LineResponse>>();
        }

        public void AddCriteriaMessage(Criteria criteria, List<LineResponse> responce)
        {
            criteriaDict.Add(criteria, responce);
        }

        public List<LineResponse> GetCriteriaResponce(Criteria criteria)
        {
            List<LineResponse> responce;
            if (criteriaDict.TryGetValue(criteria, out responce))
            {
                return responce;
            }
            return null;
        }

    }
}
