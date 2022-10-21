using Microsoft.AspNetCore.Mvc;
using RecruitmentTask.Core.Dtos;
using RecruitmentTask.Core.Interfaces;

namespace RecruitmentTask.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{directoryId}")]
        [ProducesResponseType(typeof(IEnumerable<ProductResultDto>), StatusCodes.Status200OK)]
        public IActionResult Get(int directoryId)
        {
            try
            {
                var products = _productRepository.GetProductsDirectory(directoryId);
                return Ok(products);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProductResultDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromBody] ProductDto productDto)
        {
            try
            {
                var productToReturn = await _productRepository.AddAsync(productDto);
                return Ok(productToReturn);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
