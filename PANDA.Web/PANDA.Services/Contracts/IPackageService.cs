using System.Collections.Generic;
using PANDA.Models.Domain;
using PANDA.Models.ViewModels;

namespace PANDA.Services.Contracts
{
    public interface IPackageService
    {
        IEnumerable<PackageViewModel> GetUserPendingPackages(ApplicationUser user);
        IEnumerable<PackageViewModel> GetUserShippedPackages(ApplicationUser user);
        IEnumerable<PackageViewModel> GetUserDeliveredPackages(ApplicationUser user);
        IEnumerable<PendingViewModel> GetAllPendingPackages();
        IEnumerable<ShippedViewModel> GetAllShippedPackages();
        IEnumerable<DeliveredViewModel> GetAllDeliveredPackages();
        PackageDetailsViewModel GetPackageDetails(ApplicationUser user, int id);

        Package GetCurrentUserPackage(int id);
    }
}
