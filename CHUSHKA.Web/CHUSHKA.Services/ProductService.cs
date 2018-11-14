using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHUSHKA.Data;
using CHUSHKA.Models.Domain;
using CHUSHKA.Models.Enumerations;
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

        public async Task CreateProduct(Product input)
        {
            this.dbContext.Products.Add(input);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditProduct(ProductDetailsViewModel input, int id)
        {
            var product = await this.dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Name = input.Name;
            product.Price = input.Price;
            product.Description = input.Description;
            product.Type = (ProductType) Enum.Parse(typeof(ProductType), input.Type, true);

            this.dbContext.Update(product);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await this.dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            this.dbContext.Products.Remove(product);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task OrderProduct(int userId, int productId)
        {
            var order = new Order()
            {
                ClientId = userId,
                ProductId = productId,
                OrderedOn = DateTime.UtcNow
            };
            
            await this.dbContext.Orders.AddAsync(order);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
