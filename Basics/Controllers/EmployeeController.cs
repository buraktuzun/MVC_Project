using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return View("Index");
        }

        public IActionResult Index3()
        {
            var employees = new List<Employee>()
            {
                new Employee(){FullName = "Taha Burak Tüzün", Age = 30, Index = 1},
                new Employee(){FullName = "Mina Tüzün", Age = 11, Index = 2},
                new Employee(){FullName = "Furkan Bora Tüzün", Age = 30, Index = 3}
            };
            return View("Index3", employees);
        }
    }
}