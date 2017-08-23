using Eve.DataClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class ReviewPeriodMockData
    {
        public List<ReviewPeriod> InitializeReviewPeriodMockData()
        {
            List<ReviewPeriod> periods = new List<ReviewPeriod>();

            periods.Add(new ReviewPeriod(0, "New Hire 3rd Month Review"));
            periods.Add(new ReviewPeriod(1, "New Hire 4th Month Review"));
            periods.Add(new ReviewPeriod(2, "Midyear Review"));
            periods.Add(new ReviewPeriod(3, "Year-end Review"));

            return periods;
        }
    }
}
