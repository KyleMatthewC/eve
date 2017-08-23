using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class AttributeItem
    {
        public Characteristic attribute { get; set; }
        public List<Item> items { get; set; }

        public AttributeItem(Characteristic attribute, List<Item> items)
        {
            this.attribute = attribute;
            this.items = items;
        }
    }
}
