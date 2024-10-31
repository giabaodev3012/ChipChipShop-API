using ChipChipShop.ViewModels.Catalog.Products;
using ChipChipShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChipChipShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}