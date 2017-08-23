using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eve.Web.Controllers
{
    public class EditEvaluationController : Controller
    {
        public ActionResult EditEvaluation()
        {
            return View("EditEvaluation");
        }
    }
}
