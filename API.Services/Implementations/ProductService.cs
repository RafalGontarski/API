using API.Database.EntityFramework.Domain;
using API.Domain.Dtos;
using API.Domain.Entities;
using API.Services.Abstractions.Interfaces;

namespace API.Services.Implementations
{
    public class ProductService(AppDbContext context) : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }
        public Product Create(ProductDto productDto)
        {
            var newProduct = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                ImageUrl = productDto.ImageUrl
            };

            context.Add(newProduct);
            return newProduct;
        }
    }
}
