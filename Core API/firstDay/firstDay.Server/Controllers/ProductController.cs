using firstDay.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstDay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _db;

        public ProductController (MyDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct()
        {
            var products = _db.Products.ToList();
            return Ok(products);
        }


        [HttpGet("GetProductByID")]
        public IActionResult GetProductByID(int id)
        {
            var Product = _db.Products.FirstOrDefault(x => x.ProductId == id);
            if (Product != null)
            {
                return Ok(Product);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetProductByName")]
        public IActionResult GetProductByNme(string name)
        {
            var Product = _db.Products.FirstOrDefault(x => x.ProductName == name);
            if (Product != null)
            {
                return Ok(Product);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetFirstProduct")]
        public IActionResult GetFirstProduct()
        {
            var Product = _db.Products.First();
            if (Product != null)
            {
                return Ok(Product);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
