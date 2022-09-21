using Microsoft.AspNetCore.Mvc;
using DI_Demo.Models;
namespace DI_Demo.Controllers
{
    public class EmployeeController : Controller
    {

        //Employees empObj = new Employees(); //this is the real crime

        Employees _empObj; //do not instanciate the object

        public EmployeeController(Employees _empObjREF)
        {
            _empObj = _empObjREF;
        }



        public IActionResult ShowAllEmployees()
        {

            return View(_empObj.GetEmployeesList());
        }

        public IActionResult SearchEmployee(int empNo)
        {
            return View(_empObj.GetEmpById(empNo));
        }

        //[HttpPost]
        //public IActionResult SearchEmployee(int empNo)
        //{
        //    return View(empObj.GetEmpById(empNo));
        //}




    }
}
