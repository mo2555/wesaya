using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wesaya.Dtos;
using wesaya.IServices;
using wesaya.Models;

namespace wesaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync(CategoryDto dto)
        {

            var status = await _categoryService.AddCategoryAsync(dto);

            if (!status.Success)
            {

                return BadRequest(status);
            }
            return Ok(status);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {

            var status = await _categoryService.GetAllCategoriesAsync();

            if (!status.Success)
            {

                return BadRequest(status);
            }
            return Ok(status);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {

            var status = await _categoryService.DeleteCategoryAsync(id);

            if (!status.Success)
            {

                return BadRequest(status);
            }
            return Ok(status);

        }

    }
}
