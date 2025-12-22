using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class GiftService
    {
        private readonly IGiftRepository _repository;
        public GiftService(IGiftRepository repository)
        {
            _repository = repository;
        }
    }
}
