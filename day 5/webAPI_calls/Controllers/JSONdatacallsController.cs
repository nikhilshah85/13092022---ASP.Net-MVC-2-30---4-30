using Microsoft.AspNetCore.Mvc;
using webAPI_calls.Models;
namespace webAPI_calls.Controllers
{
    public class JSONdatacallsController : Controller
    {
        public IActionResult PostData()
        {
            return View();
        }

        public IActionResult GetCommentsData()
        {
            return View();
        }

        public IActionResult GetPostDataServerEnd()
        {
            PostModel pObj = new PostModel();
            ViewBag.postDat = pObj.CallPostAPI();
            return View();
        }
    }
}
