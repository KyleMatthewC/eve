using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eve;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Text;
using Eve.Web.ViewModels;
using Eve.Web.APIControllers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eve.Web.Controllers
{
    public class SigninController : Controller
    {
        // GET: Default
        public ActionResult Signin()
        {
            return View("Signin");
        }

        public ActionResult Login(LoginViewModel model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64458/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HTTP POST
                var postTask = client.PostAsJsonAsync<LoginViewModel>("api/UserAccount/login", model);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("NewEvaluation", "FillUpEvaluationForm");
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View("Signin");
                }
            };
            
        }
    }
}