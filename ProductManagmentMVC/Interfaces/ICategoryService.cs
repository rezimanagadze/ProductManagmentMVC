using ProductManagmentMVC.Entity;
using ProductManagmentMVC.Models;

namespace ProductManagmentMVC.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category>GetCategories();
        CreateCategoryResponse CreateCategory(CategoryModel request);
        GetCategoryResponse GetCategory(GetCategoryRequest request);
        UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request);
        DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request);


    }
}
