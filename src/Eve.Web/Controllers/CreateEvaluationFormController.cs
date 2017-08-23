using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Eve.Web.Controllers
{
    public class CreateEvaluationFormController : Controller
    {
        public ActionResult CreateEvaluationForm()
        {
            return View("CreateEvaluationForm");
        }
    }
}
