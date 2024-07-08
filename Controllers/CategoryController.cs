using Microsoft.AspNetCore.Mvc;
using TP2Core.Models;
using TP2Core.Repositories;
using System.Threading.Tasks;

namespace TP2Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryInterface _categoryInterface;
        public CategoryController(ICategoryInterface categoryInterface)
        {
            _categoryInterface = categoryInterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var cat = await _categoryInterface.GetAllCategories();
            return Ok(cat);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCategory([FromBody] Categorie category)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cat = await _categoryInterface.CreateCategory(category);
            return Ok(cat);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] Categorie category)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cat = await _categoryInterface.EditCategory(id, category);
            return Ok(cat);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var cat = await _categoryInterface.DeleteCategory(id);
            return Ok(cat);
        }
    }
}
