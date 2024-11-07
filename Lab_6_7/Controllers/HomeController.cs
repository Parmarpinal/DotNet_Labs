using Lab_6_7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_6_7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Student()
        {
            List<Object> students = [
                new {StudentName = "ABC",RollNo = 101,Sem1SPI =9.87,Sem2SPI =9.77,Sem3SPI =8.87,Sem4SPI =9.56},
                new {StudentName = "DEF",RollNo = 102,Sem1SPI =9.86,Sem2SPI =9.47,Sem3SPI =7.87,Sem4SPI =9.51},
                new {StudentName = "GHI",RollNo = 103,Sem1SPI =9.85,Sem2SPI =9.57,Sem3SPI =8.87,Sem4SPI =7.77},
                new {StudentName = "JKL",RollNo = 104,Sem1SPI =9.84,Sem2SPI =9.87,Sem3SPI =6.87,Sem4SPI =8.45},
                new {StudentName = "MN",RollNo = 105,Sem1SPI =9.83,Sem2SPI =9.80,Sem3SPI =9.87,Sem4SPI =8.65},
                ];
            ViewBag.Students = students;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
