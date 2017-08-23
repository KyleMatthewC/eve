using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Token.Server.ViewModels;
using Microsoft.AspNetCore.Http.Authentication;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Token.Server.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private IIdentityServerInteractionService _interaction;

        public AccountController(UserManager<IdentityUser> userManager, IIdentityServerInteractionService interaction)
        {
            _userManager = userManager;
            _interaction = interaction;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var identityUser = await _userManager.FindByNameAsync(loginViewModel.UserName);

                if (identityUser != null
                    && await _userManager.CheckPasswordAsync(identityUser, loginViewModel.Password))
                {

                    await HttpContext.Authentication.SignInAsync(identityUser.Id, identityUser.UserName);

                    if (_interaction.IsValidReturnUrl(loginViewModel.ReturnUrl))
                        return Redirect(loginViewModel.ReturnUrl);

                    return Redirect("~/");
                }

                ModelState.AddModelError("", "Invalid username or password.");
            }

            return View(loginViewModel);
        }
    }
}
