using Eve.DataClass;
using Eve.Mock_Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Models
{
    public class FillUpEvaluationModel
    {
        private List<JobRole> _jobRoles = new List<JobRole>();
        private List<ReviewPeriod> _periods = new List<ReviewPeriod>();
        private List<Criterion> _criterias = new List<Criterion>();
        private List<Characteristic> _attributes = new List<Characteristic>();
        private List<Item> _items = new List<Item>();

        public FillUpEvaluationModel()
        {
            _jobRoles = new JobRoleMockData().InitializeJobRolesMockData();
            _periods = new ReviewPeriodMockData().InitializeReviewPeriodMockData();
            _criterias = new EvaluationFormMockData().InitializeCriteria();
            _attributes = new EvaluationFormMockData().InitializeAttributes();
            _items = new EvaluationFormMockData().InitializeEvalFormItemMockData();
        }

        public List<JobRole> GetJobRoles()
        {
            return _jobRoles;
        }

        public List<ReviewPeriod> GetReviewPeriods()
        {
            return _periods;
        }

        public List<CriteriaAttribute> GetCriteriaItems(int jobRoleID)
        {
            List<CriteriaAttribute> list = new List<CriteriaAttribute>();

            foreach(Criterion item in _criterias)
            {
                list.Add(new CriteriaAttribute(item, GetAttributeItems(jobRoleID, item.criteriaID)));
            }
            return list;
        }

        public List<AttributeItem> GetAttributeItems(int jobRoleID, int criteriaID)
        {
            List<AttributeItem> list = new List<AttributeItem>();
            
            foreach(Characteristic item in _attributes)
            {
                list.Add(new AttributeItem(item, GetItems(jobRoleID, criteriaID, item.attributeID)));
            }

            return list;
        }

        public List<Item> GetItems(int jobRoleID, int criteriaID, int attributeID)
        {
            List<Item> list = new List<Item>();

            foreach(Item item in _items)
            {
                if (item.jobRoleID == jobRoleID && item.criteriaID == criteriaID && item.attributeID == attributeID)
                    list.Add(item);
            }

            return list;
        }
    }
}
