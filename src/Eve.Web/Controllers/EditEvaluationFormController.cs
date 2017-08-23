using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Eve.Web.Controllers
{
    public class EditEvaluationFormController : Controller
    {
        public ActionResult EditEvaluationForm()
        {
            return View("EditEvaluationForm");
        }
    }
}