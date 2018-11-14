using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Web.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (!this.User.Identity.IsAuthenticated) return this.View();

            return View();
        }
    }
}
