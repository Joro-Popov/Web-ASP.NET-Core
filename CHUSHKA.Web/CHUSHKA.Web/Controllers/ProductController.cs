using System;
using System.Threading.Tasks;
using CHUSHKA.Models.Domain;
using CHUSHKA.Models.Enumerations;
using CHUSHKA.Models.ViewModels;
using CHUSHKA.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int id)
        {
            var product = await this.productService.GetProductById(id);

            // TODO: handle if product does not exists

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
        [Authorize(Roles = "Admin")]
        public IActionResult Order(int id)
        {
            // TODO: process order

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
        public IActionResult Delete(int id)
        {
            //TODO: process delete

            return this.RedirectToAction("Index", "Home");
        }
    }
}
