using AspNetCoreWebAPIProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {



        private readonly ApplicationDBContext _dbContext;

        public ProductController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = _dbContext.Products.ToList();
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var prod = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);


            return new JsonResult(prod);
        }

        // POST api/<ProductController>
        [HttpPost]
        public JsonResult Post( Product value)
        {
            Product newProduct = new Product() { Name = value.Name, Price = value.Price };


            _dbContext.Products.Add(newProduct);
            _dbContext.SaveChanges();
            return new JsonResult(newProduct);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, Product value)
        {
            var product = _dbContext.Products.FirstOrDefault(y => y.ProductId == id);
            product.Name = value.Name;
            product.Price = value.Price;
            _dbContext.Update(product);
            _dbContext.SaveChanges();


        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var prod = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);
            _dbContext.Products.Remove(prod);
            _dbContext.SaveChanges();

        }
    }
}
