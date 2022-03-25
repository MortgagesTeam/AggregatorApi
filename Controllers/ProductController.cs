using AggregatorApi.Models;
using AggregatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productservice)=>
            _productService = productservice;


        [HttpGet]
        public async Task<List<Product>> Get() =>
           await _productService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Product>> Get(string id)
        {
            var product = await _productService.GetAsync(id);

            if (product is null)
            {
                return NotFound();
            }

            return product;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product newProduct)
        {
            await _productService.CreateAsync(newProduct);

            return CreatedAtAction(nameof(Get), new { id = newProduct.ProductId }, newProduct);
        }
    }
}
