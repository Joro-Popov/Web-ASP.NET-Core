using System;
using System.Threading.Tasks;
using CHUSHKA.Models.Domain;
using CHUSHKA.Models.Enumerations;
using CHUSHKA.Models.ViewModels;
using CHUSHKA.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly UserManager<ApplicationUser> userManager;

        public ProductController(IProductService productService, UserManager<ApplicationUser> userManager)
        {
            this.productService = productService;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var product = await this.productService.GetProductById(id);
            
            return this.View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateProductViewModel input)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    Description = input.Description,
                    Name = input.Name,
                    Price = input.Price,
                    Type = (ProductType) Enum.Parse(typeof(ProductType), input.ProductType, true)
                };

                await this.productService.CreateProduct(product);

                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Order(int productId)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            await this.productService.OrderProduct(user.Id, productId);
            
            return this.RedirectToAction("Index","Home");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await this.productService.GetProductById(id);

            return this.View(product);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(ProductDetailsViewModel input, int id)
        {
            if (ModelState.IsValid)
            {
                await this.productService.EditProduct(input, id);
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await this.productService.GetProductById(id);

            return this.View(product);
        }
        
        [HttpPost("Users/Delete/{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await this.productService.DeleteProduct(id);

            return this.RedirectToAction("Index", "Home");
        }
    }
}
