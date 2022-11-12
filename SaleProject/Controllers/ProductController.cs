using SaleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SaleProject.Extensions;
using SaleProject.Database;

namespace SaleProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddProduct(ProductDTO model)
        {
            bool hasError = false;
            string message = "";
            try
            {
                if (model != null)
                {
                    Product product = new Product();
                    Extensions.Extensions.Map(model, product);
                    using (var db = DBInstance.CreateInstance())
                    {
                        var addedProduct = db.Products.Add(product);

                    }

                }
            }
            catch (Exception e)
            {

                hasError = true;
                message = e.Message;
            }
            return Json( new { hasError = hasError,message = message});
        }
    }
}