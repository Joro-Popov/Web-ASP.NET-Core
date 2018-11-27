using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Models.ViewModels;
using Eventures.Web.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class UsersController : BaseController
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (this.User.Identity.IsAuthenticated) return this.RedirectToAction("Index", "Home");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel input, string returnUrl = null)
        {
            if (this.User.Identity.IsAuthenticated) return this.RedirectToAction("Index", "Home");

            returnUrl = returnUrl ?? Url.Content("~/");

            if (!ModelState.IsValid) return this.View();

            var result = await signInManager.PasswordSignInAsync(input.Username, input.Password, input.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return this.View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (this.User.Identity.IsAuthenticated) return this.RedirectToAction("Index", "Home");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel input, string returnUrl = null)
        {
            if (this.User.Identity.IsAuthenticated) return this.RedirectToAction("Index", "Home");

            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = input.Username,
                    Email = input.Email,
                    FirstName = input.FirstName,
                    LastName = input.LastName,
                    UCN = input.UCN
                };

                var createResult = await userManager.CreateAsync(user, input.Password);

                await this.userManager.AddToRoleAsync(user, "User");

                if (createResult.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                foreach (var error in createResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return this.View(); 
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            if (!this.User.Identity.IsAuthenticated) return this.RedirectToAction("Index", "Home");

            await signInManager.SignOutAsync();

            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return this.RedirectToAction("Index", "Home");
            }
        }
    }
}
