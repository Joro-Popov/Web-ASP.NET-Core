using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PANDA.Models.Domain;
using PANDA.Models.Domain.Enumerations;
using PANDA.Models.ViewModels;
using PANDA.Services.Contracts;

namespace PANDA.Web.Controllers
{
    public class PackagesController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPackageService packageService;
        private readonly IReceiptsService receiptsService;

        public PackagesController(UserManager<ApplicationUser> userManager, 
                                  IPackageService packageService,
                                  IReceiptsService receiptsService)
        {
            this.userManager = userManager;
            this.packageService = packageService;
            this.receiptsService = receiptsService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Acquire(int id)
        {
            var package = this.packageService.GetCurrentUserPackage(id);

            var user = package.Recipient;

            package.Status = Status.Acquired;

            await this.userManager.UpdateAsync(user);

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Details(int id)
        {
            var package = this.packageService.GetCurrentUserPackage(id);

            var user = package.Recipient;

            var currentPackageDetails = this.packageService.GetPackageDetails(user, id);

            return this.View(currentPackageDetails);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var users = this.userManager.Users.Select(u => u.UserName).ToList();

            return this.View(users);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreatePackageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = this.userManager.Users.FirstOrDefault(u => u.UserName == model.Recipient);

                var package = new Package()
                {
                    Description = model.Description,
                    Weight = model.Weight,
                    Status = Status.Pending,
                    EstimatedDeliveryDate = null,
                    RecipientId = user.Id,
                    ShippingAddress = model.ShippingAddress
                };

                user.Packages.Add(package);

                await this.userManager.UpdateAsync(user);

                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Pending()
        {
            var pendingPackages = this.packageService.GetAllPendingPackages();

            return this.View(pendingPackages);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Shipped()
        {
            var pendingPackages = this.packageService.GetAllShippedPackages();

            return this.View(pendingPackages);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delivered()
        {
            var pendingPackages = this.packageService.GetAllDeliveredPackages();

            return this.View(pendingPackages);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Deliver(int id)
        {
            var package = this.packageService.GetCurrentUserPackage(id);

            var user = package.Recipient;

            package.Status = Status.Delivered;

            this.receiptsService.CreateReceipt(user.Id, package);

            await this.userManager.UpdateAsync(user);

            return this.RedirectToAction("Shipped", "Packages");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Ship(int id)
        {
            var package = this.packageService.GetCurrentUserPackage(id);

            var user = package.Recipient;

            var random = new Random();

            package.Status = Status.Shipped;

            package.EstimatedDeliveryDate = DateTime.Now.AddDays(random.Next(20, 40));

            await this.userManager.UpdateAsync(user);

            return this.RedirectToAction("Pending", "Packages");
        }
    }
}
