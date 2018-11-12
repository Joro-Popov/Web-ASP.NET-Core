using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PANDA.Models.Domain;
using PANDA.Services.Contracts;

namespace PANDA.Web.Controllers
{
    public class ReceiptsController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IReceiptsService receiptsService;

        public ReceiptsController(UserManager<ApplicationUser> userManager, IReceiptsService receiptsService)
        {
            this.userManager = userManager;
            this.receiptsService = receiptsService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.User);

            var receipts = this.receiptsService.GetCurrentUserReceipts(user);

            return this.View(receipts);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            var receipt = this.receiptsService.GetReceipt(user, id);

            return this.View(receipt);
        }
    }
}
