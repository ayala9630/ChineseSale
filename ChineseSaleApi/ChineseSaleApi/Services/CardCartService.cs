using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class CardCartService
    {
        private readonly ICardCartRepository _repository;
        public CardCartService(ICardCartRepository repository)
        {
            _repository = repository;
        }
    }
}