using System;
using System.Collections.Generic;
using System.Text;
using PANDA.Models.Domain;
using PANDA.Models.ViewModels;

namespace PANDA.Services.Contracts
{
    public interface IReceiptsService
    {
        IEnumerable<ReceiptsViewModel> GetCurrentUserReceipts(ApplicationUser user);

        ReceiptDetailsViewModel GetReceipt(ApplicationUser user, int id);

        void CreateReceipt(int userId, Package package);
    }
}
