using System.Collections.Generic;
using System.Threading.Tasks;
using CHUSHKA.Models.Domain;
using CHUSHKA.Models.ViewModels;

namespace CHUSHKA.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();

        Task<ProductDetailsViewModel> GetProductById(int id);

        Task CreateProduct(Product input);

        Task EditProduct(ProductDetailsViewModel input, int id);

        Task DeleteProduct(int id);

        Task OrderProduct(int userId, int productId);
    }
}
