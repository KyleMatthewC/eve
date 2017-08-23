using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class Criterion
    {
        public int criteriaID { get; set; }
        public string criteriaTitle { get; set; }

        public Criterion(int ID, string title)
        {
            this.criteriaID = ID;
            this.criteriaTitle = title;
        }
    }
}
