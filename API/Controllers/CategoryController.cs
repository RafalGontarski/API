using API.Domain.Entities;
using API.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController(ICategoryService categoryService, ILogger<ProductController> logger) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return categoryService.GetCategories();
        }

        [HttpPost]
        public Category? CreateCategory(Category category) 
        {
            if (ModelState.IsValid)
            {
                return categoryService.AddCategory(category);
            }
            return null;
        }
    }
}
