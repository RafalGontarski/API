using API.Domain.Dtos;
using API.Domain.Entities;
using API.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductService productService, ILogger<ProductController> logger) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }
        [HttpPost]
        public Product? AddProduct(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                return productService.Create(productDto);
            }
            return null;
        }
    }
}
