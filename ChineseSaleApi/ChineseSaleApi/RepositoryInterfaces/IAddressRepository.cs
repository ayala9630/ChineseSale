using ChineseSaleApi.Models;

namespace ChineseSaleApi.RepositoryInterfaces
{
    public interface IAddressRepository
    {
        Task AddAddress(Address address);
        Task<Address?> GetAddress(int id);
        Task UpdateAddress(Address address);
    }
}