using Lab_8_9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;

namespace Lab_8_9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<EmployeeModel> employees = new List<EmployeeModel>() {
            new EmployeeModel() { ID = 101, Name = "ABC", Email = "ABC@gmail.com", Designation = "HOD", Salary = 30000 },
            new EmployeeModel() { ID = 102, Name = "DEF", Email = "DEF@gmail.com", Designation = "DEAN", Salary = 50000 },
            new EmployeeModel() { ID = 103, Name = "GHI", Email = "GHI@gmail.com", Designation = "HOD", Salary = 40000 },
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("/Contact")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(IFormCollection fc)
        {
            ViewBag.User = new List<object> { fc["Name"], fc["Email"], fc["Phone"], fc["City"] };
            return View("ContactUs");
        }

        public IActionResult Employee()
        {
            return View(employees);
        }
        public IActionResult EmployeeForm(int? id)
        {           
            if(id == null)
            {
                return View(new EmployeeModel());
            }
            EmployeeModel model = new EmployeeModel();
            foreach(var v in employees)
            {
                if(v.ID == id)
                {
                    model = v;
                }
            }
            return View(model);
        }

        public IActionResult Save(EmployeeModel model)
        {
            if(model.ID == 0)
            {
                int empID;
                if (employees.Count ==  0)
                {
                    empID = 1;
                }
                else
                {
                    empID = employees.Max(x => x.ID) + 1;
                }
                employees.Add(new EmployeeModel() {
                    ID = empID,
                    Name = model.Name,
                    Designation = model.Designation,
                    Email = model.Email,
                    Salary = model.Salary
                });
            }
            else
            {
                int index = employees.FindIndex(x => x.ID == model.ID);
                employees[index].Name = model.Name;
                employees[index].Designation = model.Designation;
                employees[index].Email = model.Email;
                employees[index].Salary = model.Salary;
            }
            return RedirectToAction("Employee");
        }

        public IActionResult Delete(int id)
        {
            int index = employees.FindIndex(x => x.ID == id);
            employees.RemoveAt(index);
            return RedirectToAction("Employee");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
