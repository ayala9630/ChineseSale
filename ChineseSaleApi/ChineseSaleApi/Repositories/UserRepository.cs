using ChineseSaleApi.Data;
using ChineseSaleApi.RepositoryInterfaces;

namespace ChineseSaleApi.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ChineseSaleContext _context;
        public UserRepository(ChineseSaleContext context)
        {
            _context = context;
        }
    }
}
