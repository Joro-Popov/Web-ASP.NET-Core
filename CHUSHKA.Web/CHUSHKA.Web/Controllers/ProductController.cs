using System.Threading.Tasks;
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

            return this.View(product);
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
        public IActionResult Edit(int id)
        {
            // TODO: process edit

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
