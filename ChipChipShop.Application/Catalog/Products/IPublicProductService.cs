using ChipChipShop.ViewModels.Catalog.Products;
using ChipChipShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChipChipShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
         
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}