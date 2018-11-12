using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PANDA.Models.Domain;
using PANDA.Models.ViewModels;
using PANDA.Services.Contracts;

namespace PANDA.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IPackageService packageService;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IPackageService packageService, UserManager<ApplicationUser> userManager)
        {
            this.packageService = packageService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!this.User.Identity.IsAuthenticated) return this.View();

            var user = await this.userManager.GetUserAsync(this.User);

            var pendingPackages = this.packageService.GetUserPendingPackages(user);

            var shippedPackages = this.packageService.GetUserShippedPackages(user);

            var deliveredPackages = this.packageService.GetUserDeliveredPackages(user);

            this.ViewBag.Username = user.UserName;

            var packages = new PackagesViewModel()
            {
                PendingPackages = pendingPackages,
                ShippedPackages = shippedPackages,
                DeliveredPackages = deliveredPackages
            };

            return View(packages);
        }
    }
}
