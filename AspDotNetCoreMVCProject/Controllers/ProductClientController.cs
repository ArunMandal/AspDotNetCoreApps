using AspDotNetCoreMVCProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspDotNetCoreMVCProject.Controllers
{
    public class ProductClientController : Controller
    {
        // GET: ProductClientController
        public async Task< ActionResult> Index()
        {
            List<Product> products = new List<Product>();
            using (var client=new HttpClient())
            {
                using(var response= await client.GetAsync("http://localhost:5145/api/Product"))
                {
                    string apiResponse= await response.Content.ReadAsStringAsync();
                    products=JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                }
            }

            return View(products);
        }

        // GET: ProductClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
