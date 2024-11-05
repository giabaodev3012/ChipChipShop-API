using ChipChipShop.ViewModels.System.Users;

namespace ChipChipShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
