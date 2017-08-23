using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eve;
using Eve.DataClass;

namespace Eve.Web.ViewModels
{
    public class FillUpEvaluationFormViewModel
    {
        public List<JobRole> Roles { get; set; }
        public List<ReviewPeriod> Periods { get; set; }
    }
}
