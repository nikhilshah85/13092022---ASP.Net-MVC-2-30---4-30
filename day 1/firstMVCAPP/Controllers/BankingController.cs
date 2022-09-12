using Microsoft.AspNetCore.Mvc;

namespace firstMVCAPP.Controllers
{
    public class BankingController : Controller
    {
      
        public IActionResult BankingHome()
        {
            ViewBag.developer = "Nikhil Shah";
            ViewBag.teamSize = 30;
            List<string> tList = new List<string>() { ".Net","MVC","SQL Server", "Bootstrap","JQuery","Azure"};
            ViewBag.techList = tList;
            ViewBag.isProjectLive = true;

            return View();
        }

        public IActionResult BankingServices()
        {
            return View();
        }

        public IActionResult TransferFunds()
        {
            //collect data from Model to be passed to view - or vice-versa
            return View();
        }


    }
}
