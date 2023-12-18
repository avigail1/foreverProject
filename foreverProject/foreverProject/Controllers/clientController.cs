using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foreverProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clientController : ControllerBase
    {
        private static List<client> clients = new List<client>
        {
            new client
            {
                ClientName="aaa",
                IdClient=0,
                MyProducts=new List<product>{
                     new product { ProductId = 0, ProductName = "zzz", ProductPrice = 13 },
                     new product { ProductId =1, ProductName = "fff", ProductPrice = 17 },
                     new product { ProductId = 2, ProductName = "ttt", ProductPrice = 25 },
                }
            },
             new client
            {
                ClientName="rrr",
                IdClient=1,
                MyProducts=new List<product>{
                     new product { ProductId =1, ProductName = "fff", ProductPrice = 17 },
                     new product { ProductId = 2, ProductName = "ttt", ProductPrice = 25 },
                }
            }
        };
        // GET: api/<clientController>
        [HttpGet]
        public IEnumerable<client> Get()
        {
            return clients;
        }

        // GET api/<clientController>/5
        [HttpGet("{id}")]
        public client Get(int id)
        {
            var c = clients.Find(c => c.IdClient == id);
            return c;
        }

        // POST api/<clientController>
        [HttpPost]
        public void Post([FromBody] client value)
        {
            clients.Add(value);
        }

        // PUT api/<clientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] client value)
        {
            var c = clients.Find(c => c.IdClient == id);
            c.MyProducts = value.MyProducts;
            c.IdClient = value.IdClient;
            c.ClientName = value.ClientName;
        }

        // DELETE api/<clientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)

        {
            var c = clients.Find(c => c.IdClient == id);
            clients.Remove(c);
        }
    }
}
