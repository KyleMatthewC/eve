using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eve.Web.Controllers
{
    public class EvaluationSummaryController : Controller
    {
        public ActionResult EvaluationSummary(int jobRoleID)
        {
            return View("_partialSummaryView");
        }
    }
}
