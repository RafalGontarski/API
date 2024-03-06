using API.Domain.Entities;

namespace API.Services.Abstractions.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();      
        Category AddCategory(Category category);
    }
}
