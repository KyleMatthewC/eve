using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eve.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult UserHome()
        {
            return View("UserHome");
        }
    }
}
