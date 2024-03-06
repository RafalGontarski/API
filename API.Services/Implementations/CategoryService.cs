using API.Database.EntityFramework.Domain;
using API.Domain.Entities;
using API.Services.Abstractions.Interfaces;

namespace API.Services.Implementations
{
    public class CategoryService(AppDbContext context) : ICategoryService
    {       
        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        public Category AddCategory(Category category)
        {
            var newCategory = new Category()
            {
                Id = category.Id,
                Name = category.Name,
                CategoryId = category.CategoryId,
                ParentCategory = category.ParentCategory
            };
            context.Categories.Add(newCategory);
            return newCategory;
        }
    }
}
