using ChineseSaleApi.Dto;

namespace ChineseSaleApi.Services
{
    public interface IAddressService
    {
        Task AddAddressForDonor(CreateAddressForDonorDto address);
        Task AddAddressForUser(CreateAddressForUserDto address);
        Task<AddressDto?> GetAddressById(int id);
    }
}