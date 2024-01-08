using AspDotNetCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreMVCProject.Controllers
{
    [Route("custom/[action]")]
    public class CustomerController : Controller
    {
       // [Route("Indexwa")]
        public IActionResult Index()
        {
            //var customers = new
            //{
            //    Name = "arun",
            //    Age = 20
            //};
            List<Customer> list = new List<Customer>()
            {
                new Customer{Id=1, Name="Arun", Address="jank", City="jnk" },
                new Customer{Id=2, Name="Madhu", Address="jank", City="jnk" },
            };

            ViewBag.List = list;
            return View();
        }

      
       // [Route("callDetail")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
