using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PANDA.Data;
using PANDA.Models.Domain;
using PANDA.Models.ViewModels;
using PANDA.Services.Contracts;

namespace PANDA.Services
{
    public class ReceiptsService : IReceiptsService
    {
        private readonly PandaDbContext context;

        public ReceiptsService(PandaDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ReceiptsViewModel> GetCurrentUserReceipts(ApplicationUser user)
        {
            var receipts = user.Receipts
                .Select(r => new ReceiptsViewModel()
                {
                    Id = r.Id,
                    Recipient = r.Recipient.UserName,
                    Fee = r.Fee,
                    IssuedOn = r.IssuedOn.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)
                });

            return receipts;
        }

        public ReceiptDetailsViewModel GetReceipt(ApplicationUser user, int id)
        {
            var receipt = user.Receipts
                .FirstOrDefault(r => r.Id == id);

            var receiptDetails = new ReceiptDetailsViewModel()
            {
                Recipient = receipt.Recipient.UserName,
                IssuedOn = receipt.IssuedOn.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture),
                PackageWeight = receipt.Package.Weight,
                DeliveryAddress = receipt.Package.ShippingAddress,
                PackageDescription = receipt.Package.Description,
                ReceiptNumber = receipt.Id,
                Total = receipt.Package.Weight * 2.67m
            };

            return receiptDetails;
        }

        public void CreateReceipt(int userId, Package package)
        {
            var receipt = new Receipt()
            {
                Fee = package.Weight * 2.67m,
                IssuedOn = DateTime.Now,
                RecipientId = userId,
                PackageId = package.Id
            };

            this.context.Receipts.Add(receipt);
            this.context.SaveChanges();
        }
    }
}
