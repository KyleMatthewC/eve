using Eve.DataClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    public class EvaluationFormMockData
    {
        public List<Criterion> InitializeCriteria()
        {
            List<Criterion> items = new List<Criterion>();
            items.Add(new Criterion(0, "Results Leader"));
            items.Add(new Criterion(1, "People Leader"));
            return items;
        }

        public List<Characteristic> InitializeAttributes()
        {
            List<Characteristic> items = new List<Characteristic>();
            items.Add(new DataClass.Characteristic(0, "Accountability"));
            items.Add(new DataClass.Characteristic(1, "Communication"));
            return items;
        }

        public List<Item> InitializeEvalFormItemMockData()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(0, 0, 0, "Demonstrates ownership of the tasks or projects assigned", 0));
            items.Add(new Item(1, 0, 0, "Works on tasks based on appropriate prioritization", 0));
            items.Add(new Item(2, 1, 1, "Verbal and written communication are clear, concise and understandable", 0));
            items.Add(new Item(3, 1, 1, "Communicates work status to key audience timely and effectively", 0));

            items.Add(new Item(4, 0, 0, "Perseveres through task until complete and done well", 1));
            items.Add(new Item(5, 0, 0, "Adheres to company and team processes", 1));
            items.Add(new Item(6, 1, 1, "Successfully lead discussion of critical issues and ideas", 1));
            items.Add(new Item(7, 1, 1, "Assertive in raising concerns to the right channels", 1));

            return items;
        }
    }
}
