using Microsoft.EntityFrameworkCore;
using wesaya.Dtos;
using wesaya.IServices;
using wesaya.Models;

namespace wesaya.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {

            _context = context;

        }

        public async Task<ResponseModel> AddCategoryAsync(CategoryDto dto)
        {
            
               CategoryModel category = new CategoryModel { 

                IsActive=dto.IsActive,
                Name=dto.Name

               };

            await _context.Categories.AddAsync(category);

            await _context.SaveChangesAsync();

            return new ResponseModel
            {
                Success=true,
                Data= category,
                Message="Data added successfully"
            };


        }

        public async Task<ResponseModel> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return new ResponseModel
                {
                    Message = "Category not found!!"
                };
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return new ResponseModel
            {
                Success = true,
                Data = category,
                Message = "Data deleted successfully"
            };

        }

        public async Task<ResponseModel> GetAllCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();


            return new ResponseModel
            {
                Success = true,
                Data = categories
            };
        }
    }
}
