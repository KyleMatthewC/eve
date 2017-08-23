using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Eve.Web.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult UserHome()
        {
            return View("UserHome");
        }
    }
}
