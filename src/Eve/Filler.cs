using System;
using System.Collections.Generic;
using System.Text;

namespace Eve
{
    class Filler
    {
        public CriteriaMap FillCriteriaMap()
        {
            CriteriaMap criteriaMap = new CriteriaMap();
            List<LineResponse> list = new List<LineResponse>();

            // Accountability
            list.Add(new LineResponse("- Work on defined and standard tasks with regular guidance from the lead"));
            list.Add(new LineResponse("- Follow the proper task prioritization as discussed with leads"));
            list.Add(new LineResponse("- Perseveres through tasks and execute them in detail and completely."));
            list.Add(new LineResponse("- Adheres to company and team processes"));
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.IndividualContributor12), list);
            // reset
            list = new List<LineResponse>();

            return criteriaMap;
        }
    }
}
