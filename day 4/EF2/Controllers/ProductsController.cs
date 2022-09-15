using Microsoft.AspNetCore.Mvc;
using EF2.Models.EF;
namespace EF2.Controllers
{
    public class ProductsController : Controller
    {
        MVC_EFContext db = new MVC_EFContext();

        public IActionResult Products()
        {
            
            return View(db.Products.ToList());
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
