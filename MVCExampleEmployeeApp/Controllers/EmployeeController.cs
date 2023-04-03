using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCExampleEmployeeApp.Models.EmployeeApplication.Models;
using MVCExampleEmployeeApp.Models;


namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(EmployeeData.Employees);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            EmployeeViewModel model = new EmployeeViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel model)
        {
            EmployeeData.Employees.Add(model);
            return RedirectToAction("Index");
        }
    }
}