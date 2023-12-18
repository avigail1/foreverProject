using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foreverProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private static List<product> products = new List<product>{
                     new product { ProductId = 0, ProductName = "zzz", ProductPrice = 13 },
                     new product { ProductId =1, ProductName = "fff", ProductPrice = 17 },
                     new product { ProductId = 2, ProductName = "ttt", ProductPrice = 25 },

            };
        // GET: api/<productController>
        [HttpGet]
        public IEnumerable<product> Get()
        {
            return products;
        }

        // GET api/<productController>/5
        [HttpGet("{id}")]
        public product Get(int id)
        {
            var p = products.Find(p => p.ProductId == id);
            return p;
        }

        // POST api/<productController>
        [HttpPost]
        public void Post([FromBody] product value)
        {
            products.Add(value);
        }

        // PUT api/<productController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] product value)
        {
            var p = products.Find(p => p.ProductId == id);
            p.ProductName = value.ProductName;
            p.ProductPrice = value.ProductPrice;
            p.ProductId = id;
        }

        // DELETE api/<productController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var p = products.Find(p => p.ProductId == id);
            products.Remove(p);
        }
    }
}
