using firstDay.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstDay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _db;

        public CategoryController(MyDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory() { 
            var categories = _db.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("GetCategoryByID")]
        public IActionResult GetCategoryByID(int id) { 
            var category = _db.Categories.FirstOrDefault(x=>x.CategoryId == id);
            if (category != null)
            {
                return Ok(category);
            }
            else { 
                return NotFound();
            }
        
        }

        [HttpGet("GetCategoryByName")]
        public IActionResult GetCategoryByNme(string name)
        {
            var category = _db.Categories.FirstOrDefault(x => x.CategoryName == name);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetFirstCategory")]
        public IActionResult GetFirstCategory()
        {
            var category = _db.Categories.First();
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }

        }

    }
}
