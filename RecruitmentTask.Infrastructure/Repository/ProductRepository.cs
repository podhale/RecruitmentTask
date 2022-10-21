using AutoMapper;
using RecruitmentTask.Core.Dtos;
using RecruitmentTask.Core.Entities;
using RecruitmentTask.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTask.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISimpleApiContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ISimpleApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductResultDto> AddAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _context.Products.Add(product);
            
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductResultDto>(product);
        }

        public IEnumerable<ProductResultDto> GetProductsDirectory(int directoryId)
        {
            return _context.Products
                .Where(x => x.DirectoryId == directoryId)
                .ToList()
                .Select(product => _mapper.Map<ProductResultDto>(product));
        }
    }
}
