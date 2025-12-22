using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class PackageCartService
    {
        private readonly IPackageCartRepository _repository;
        public PackageCartService(IPackageCartRepository repository)
        {
            _repository = repository;
        }
    }
}