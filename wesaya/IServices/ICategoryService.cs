using wesaya.Dtos;
using wesaya.Models;

namespace wesaya.IServices
{
    public interface ICategoryService
    {

        Task<ResponseModel> AddCategoryAsync(CategoryDto dto);
        Task<ResponseModel> GetAllCategoriesAsync();
        Task<ResponseModel> DeleteCategoryAsync(int id);

    }
}
