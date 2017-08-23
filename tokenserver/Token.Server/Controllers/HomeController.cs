using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityServer4.Services;
using Token.Server.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Token.Server.Controllers
{
    public class HomeController : Controller
    {
        private IIdentityServerInteractionService _interaction;

        public HomeController (IIdentityServerInteractionService interaction)
        {
            _interaction = interaction;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task<IActionResult> Error(string errorID)
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            var message = await _interaction.GetErrorContextAsync(errorID);
            if (message != null)
                errorViewModel.Error = message;
            return View("Error", errorViewModel);
        }
    }
}
