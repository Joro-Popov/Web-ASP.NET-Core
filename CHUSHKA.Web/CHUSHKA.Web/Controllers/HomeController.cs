using System.Threading.Tasks;
using CHUSHKA.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!this.User.Identity.IsAuthenticated) return this.View();

            var allProducts = await this.productService.GetAllProducts();

            return View(allProducts);
        }
    }
}
