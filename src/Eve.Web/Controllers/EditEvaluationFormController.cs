using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eve.Web.Controllers
{
    public class EditEvaluationFormController : Controller
    {
        // GET: EditEvaluationForm
        public ActionResult EditEvaluationForm()
        {
            return View("EditEvaluationForm");
        }
    }
}