using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foreverProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sellersController : ControllerBase
    {
        private static List<seller> sellers = new List<seller>
        {
            new seller
            {
                IdSeller = 1,
                NameSeller = "aaa",
                MyProducts=new List<product>{
                     new product { ProductId = 0, ProductName = "zzz", ProductPrice = 13 },
                     new product { ProductId =1, ProductName = "fff", ProductPrice = 17 },
                     new product { ProductId = 2, ProductName = "ttt", ProductPrice = 25 },
                }
            },
            new seller
            {
                IdSeller = 2,
                NameSeller = "bbb",
                MyProducts=new List<product>{
                     new product { ProductId = 0, ProductName = "zzz", ProductPrice = 13 },
                     new product { ProductId = 2, ProductName = "ttt", ProductPrice = 25 },
                     new product { ProductId =9, ProductName = "ppp", ProductPrice =235 },
                }
            }
        };

        // GET: api/<sellersController>
        [HttpGet]
        public IEnumerable<seller> Get()
        {
            return sellers;
        }

        // GET api/<sellersController>/5
        [HttpGet("{id}")]
        public seller Get(int id)
        {
            var s = sellers.Find(s => s.IdSeller == id);
            return s;
        }

        // POST api/<sellersController>
        [HttpPost]
        public void Post([FromBody] seller value)
        {
            sellers.Add(value);
        }

        // PUT api/<sellersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] seller value)
        {
            var s = sellers.Find(s => s.IdSeller == id);
            s.MyProducts = value.MyProducts;
            s.IdSeller=id;
            s.NameSeller = value.NameSeller;
        }

        // DELETE api/<sellersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var s = sellers.Find(s => s.IdSeller == id);
            sellers.Remove(s);
        }
    }
}
