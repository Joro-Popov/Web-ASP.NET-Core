using System.Collections.Generic;

namespace PANDA.Models.ViewModels
{
    public class PackagesViewModel
    {
        public IEnumerable<PackageViewModel> PendingPackages { get; set; }
        public IEnumerable<PackageViewModel> ShippedPackages { get; set; }
        public IEnumerable<PackageViewModel> DeliveredPackages { get; set; }
    }
}
