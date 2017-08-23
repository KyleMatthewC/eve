using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class ReviewPeriod
    {
        public int periodID { get; set; }

        public string period { get; set; }

        public ReviewPeriod(int id, string period)
        {
            this.periodID = id;
            this.period = period;
        }
    }
}
