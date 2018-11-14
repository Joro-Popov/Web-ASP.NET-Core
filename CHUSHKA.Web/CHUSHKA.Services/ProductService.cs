using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHUSHKA.Data;
using CHUSHKA.Models.ViewModels;
using CHUSHKA.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Services
{
    public class ProductService : IProductService
    {
        private readonly ChushkaDbContext dbContext;

        public ProductService(ChushkaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            var products = await this.dbContext.Products
                .Select(p => new ProductViewModel()
                {
                    ProductId = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price
                })
                .ToListAsync();

            return products;
        }

        public async Task<ProductDetailsViewModel> GetProductById(int id)
        {
            var dbProduct = await this.dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            var product = new ProductDetailsViewModel()
            {
                Description = dbProduct.Description,
                ProductId = dbProduct.Id,
                Name = dbProduct.Name,
                Price = dbProduct.Price,
                Type = dbProduct.Type.ToString()
            };

            return product;
        }
    }
}
