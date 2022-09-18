using Microsoft.AspNetCore.Mvc;

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
    }
}
