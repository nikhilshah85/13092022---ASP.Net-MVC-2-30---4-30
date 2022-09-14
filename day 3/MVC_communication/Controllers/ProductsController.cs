using Microsoft.AspNetCore.Mvc;
using MVC_communication.Models;
namespace MVC_communication.Controllers
{
    public class ProductsController : Controller
    {

        ProductsModel pObj = new ProductsModel();
       public IActionResult ProductsHome()
        {
            ViewBag.developer = "Nikhil";
            ViewBag.appName = "My Shopping APP";
            ViewBag.products = pObj.ShowProducts();
            return View();
        }

        public IActionResult SearchProduct()
        {
            ViewBag.errMessage = "";
            ViewBag.hasError = true;
            return View();
        }

        [HttpPost]
        public IActionResult SearchProduct(int pId)
        {
            try
            {
                
                ViewBag.product = pObj.GetProductbyId(pId);
                ViewBag.errMessage = "";
                ViewBag.hasError = true;

            }
            catch(Exception es)
            {
                ViewBag.hasError = false;
                ViewBag.errMessage = es.Message;
            }
            return View();
        }
       static List<string> pList = new List<string>()
            {
                "Pepsi","Maggie","Pasta","Iphone","Air Pods"
              };
        public IActionResult ProductList()
        {
          
            ViewBag.pList = pList;
            return View();
        }
        [HttpPost]
        public IActionResult ProductList(string newProduct)
        {
            pList.Add(newProduct);
            ViewBag.pList = pList;
            return View();
        }

        //this is the action will will execute on Get
        public IActionResult Greetings()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Greetings(string guestName)
        {
            ViewBag.greetMessage = "Hello and Welcome to my Shopping APP" + guestName;
            return View();
        }

        public IActionResult CalculateNumbers()
        {
            ViewBag.hasValues = false;
            ViewBag.errMessage = "";
            return View();
        }
        [HttpPost]
        public IActionResult CalculateNumbers(int num1 ,int num2)
        {
            if (num1 < num2)
            {
                ViewBag.errMessage = "First Number cannot be less than second number";
                ViewBag.hasValues = false;
            }
            else if (num1 < 0 || num2 < 0)
            {
                ViewBag.errMessage = "We do not process negative numbers";
                ViewBag.hasValues = false;
            }
            else if (num2 == 0)
            {
                ViewBag.errMessage = "This will result in Divide by Zero infinity error";
                ViewBag.hasValues = false;
            }
            else
            {
                ViewBag.errMessage = "";
                ViewBag.addNumbers = num1 + num2;
                ViewBag.subNumbers = num1 - num2;
                ViewBag.mulNumbers = num1 * num2;
                ViewBag.divNumbers = num1 / num2;
                ViewBag.hasValues = true;
            }
            return View();
        }

        public IActionResult CalculateDiscount()
        {
            return View();
        }


    }
}
