using RecruitmentTask.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentTask.Core.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductResultDto> GetProductsDirectory(int directoryId);
        Task<ProductResultDto> AddAsync(ProductDto productDto);
    }
}
