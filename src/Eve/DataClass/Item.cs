using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class Item
    {
        public int itemID { get; set; }
        public int criteriaID { get; set; }
        public int attributeID { get; set; }
        public string item { get; set; }
        public int jobRoleID { get; set; }
        public Item(int ID, int criteria, int attribute, string item, int jobRoleID)
        {
            this.itemID = ID;
            this.criteriaID = criteria;
            this.attributeID = attribute;
            this.item = item;
            this.jobRoleID = jobRoleID;
        }
    }
}
