using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CHUSHKA.Models.ViewModels;

namespace CHUSHKA.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();

        Task<ProductDetailsViewModel> GetProductById(int id);
    }
}
