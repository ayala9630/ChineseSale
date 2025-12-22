using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Services
{
    public class CardService
    {
        private readonly ICardRepository _repository;
        public CardService(ICardRepository repository)
        {
            _repository = repository;
        }
    }
}