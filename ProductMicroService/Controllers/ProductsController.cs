using Microsoft.AspNetCore.Mvc;
using ProductMicroService.Model;
using ProductMicroService.Repository;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult Get()      
        {

            var products = _productRepository.GetProducts();
            return new OkObjectResult( products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var poducts = _productRepository.GetProductById(id);
            return new OkObjectResult(poducts);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            using(var scope=new TransactionScope())
            {
                _productRepository.InsertProduct(product);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new {id=product.Id},product);
            }

          
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Product product)
        {
            if(product != null)
            {
                using (var scope = new TransactionScope())
                {

                    _productRepository.UpdateProduct(product);
                    scope.Complete();
                    return new OkResult();
                }

            }
            return new NoContentResult();

            
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productRepository.DelProduct(id);
            return new OkResult();

        }
    }
}
