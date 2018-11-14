using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CHUSHKA.Data;
using CHUSHKA.Models.Domain;
using CHUSHKA.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Web.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ChushkaDbContext dbContext;

        public OrdersController(UserManager<ApplicationUser> userManager, ChushkaDbContext dbContext)
        {
            this.userManager = userManager;
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> All()
        {
            var allOrders = await dbContext.Orders
                .Select(o => new OrderViewModel()
                {
                    Product = o.Product.Name,
                    Customer = this.userManager.Users.FirstOrDefault(u => u.Id == o.ClientId).UserName,
                    OrderId = o.Id,
                    OrderedOn = o.OrderedOn.ToString("HH:mm dd/MM/yyyy",CultureInfo.InvariantCulture)
                })
                .ToListAsync();

            return this.View(allOrders);
        }
    }
}
