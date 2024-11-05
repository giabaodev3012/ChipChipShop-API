using ChipChipShop.ViewModels.Common;
using ChipChipShop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipChipShop.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserVM>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
    }
}
