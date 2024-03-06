using API.Domain.Dtos;
using API.Domain.Entities;

namespace API.Services.Abstractions.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product Create(ProductDto productDto);
    }
}
