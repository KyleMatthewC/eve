using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.DataClass
{
    public class CriteriaAttribute
    {
        public Criterion criteria { get; set; }
        public List<AttributeItem> attributeItems { get; set; }
        public CriteriaAttribute(Criterion criteria, List<AttributeItem> attributeItems)
        {
            this.criteria = criteria;
            this.attributeItems = attributeItems;
        }
    }
}
