using Microsoft.AspNetCore.Mvc;
//project name to access model from controller
using MVC.Models;

namespace MVC.Controllers
{
    //controller is ued to handle all the incoming http request. it contains group of action method (such methof that return view) that will handle incoming request.
    // Controller is a c# class and any class that is to be cotnroller must inherit superclass controller.
    // Controller to access controller from URL tab: domainName/ControllerName/methodname
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            // accessing model 
            EmployeeModel emp = new EmployeeModel()
            {
                //setting properties
                Id=1,
                Name="Ram Thapa",
                Department="IT",
                Salary=30000.0
            };
            return View(emp);
        }

        //creating normal method in controller and accessing it
        public string getName()
        {
            string name = "ram";
            return ("hello " + name);
        }

        public string printName()
        {
            return ("hello  CSIT");
        }

        public string getDetail(string name, int id)
        {
            return $"person with name ${name} and id ${id}";
        }
    }
}
