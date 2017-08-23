using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class Characteristic
    {
        public int attributeID { get; set; }
        public string attributeTitle { get; set; }

        public Characteristic(int ID, string title)
        {
            this.attributeID = ID;
            this.attributeTitle = title;
        }
    }
}
