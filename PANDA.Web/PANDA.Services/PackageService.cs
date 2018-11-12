using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PANDA.Data;
using PANDA.Models.Domain;
using PANDA.Models.Domain.Enumerations;
using PANDA.Models.ViewModels;
using PANDA.Services.Contracts;

namespace PANDA.Services
{
    public class PackageService : IPackageService
    {
        private readonly PandaDbContext dbContext;

        public PackageService(PandaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<PackageViewModel> GetUserPendingPackages(ApplicationUser user)
        {
            IEnumerable<PackageViewModel> pendingPackages = user
                .Packages.Where(p => p.Status == Status.Pending)
                .Select(p => new PackageViewModel()
                {
                    Id = p.Id,
                    Description = p.Description
                }).ToList();

            return pendingPackages;
        }

        public IEnumerable<PackageViewModel> GetUserShippedPackages(ApplicationUser user)
        {

            IEnumerable<PackageViewModel> shippedPackages = user
                .Packages.Where(p => p.Status == Status.Shipped)
                .Select(p => new PackageViewModel()
                {
                    Id = p.Id,
                    Description = p.Description
                }).ToList();

            return shippedPackages;
        }

        public IEnumerable<PackageViewModel> GetUserDeliveredPackages(ApplicationUser user)
        {
            IEnumerable<PackageViewModel> deliveredPackages = user
                .Packages.Where(p => p.Status == Status.Delivered)
                .Select(p => new PackageViewModel()
                {
                    Id = p.Id,
                    Description = p.Description
                }).ToList();

            return deliveredPackages;
        }

        public IEnumerable<PendingViewModel> GetAllPendingPackages()
        {
            var pendingPackages = this.dbContext.Packages
                .Where(p => p.Status == Status.Pending)
                .ToList()
                .Select(p => new PendingViewModel()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Recipient = p.Recipient.UserName,
                    ShippingAddress = p.ShippingAddress,
                    Weight = p.Weight,
                })
                .ToList();

            return pendingPackages;
        }

        public IEnumerable<ShippedViewModel> GetAllShippedPackages()
        {
            var shippedPackages = this.dbContext.Packages
                .Where(p => p.Status == Status.Shipped)
                .ToList()
                .Select(p => new ShippedViewModel()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Recipient = p.Recipient.UserName,
                    EstimatedDeliveryDate = p.EstimatedDeliveryDate?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Weight = p.Weight
                })
                .ToList();

            return shippedPackages;
        }

        public IEnumerable<DeliveredViewModel> GetAllDeliveredPackages()
        {
            var deliveredPackages = this.dbContext.Packages
                .Where(p => p.Status == Status.Delivered || p.Status == Status.Acquired)
                .ToList()
                .Select(p => new DeliveredViewModel()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Recipient = p.Recipient.UserName,
                    ShippingAddress = p.ShippingAddress,
                    Weight = p.Weight,
                })
                .ToList();

            return deliveredPackages;
        }

        public PackageDetailsViewModel GetPackageDetails(ApplicationUser user, int id)
        {
            var currentPackage = user.Packages
                .FirstOrDefault(p => p.Id == id);

            var details = new PackageDetailsViewModel()
            {
                Description = currentPackage.Description,
                Status = currentPackage.Status.ToString(),
                Address = currentPackage.ShippingAddress,
                EstimatedDeliveryDate = 
                    currentPackage.Status == Status.Pending? "N/A" : 
                    currentPackage.Status == Status.Shipped? 
                    currentPackage.EstimatedDeliveryDate?.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture) :
                    "Delivered",
                Recipient = currentPackage.Recipient.UserName,
                Weight = currentPackage.Weight
            };

            return details;
        }

        public Package GetCurrentUserPackage(int id)
        {
            var package = this.dbContext.Packages
                .FirstOrDefault(p => p.Id == id);

            return package;
        }
    }
}
