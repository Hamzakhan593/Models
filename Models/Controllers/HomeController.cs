using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var studentD = new List<Student>()
            {
                new Student {Id = 1, Name = "Hamza", FatherName = "Jalil"},
                new Student {Id = 2, Name = "Faryal", FatherName = "Waseem"},
                new Student {Id = 3, Name = "Bilal", FatherName = "Zafar"}
            };

            ViewBag.StudentData = studentD;
            return View();
        }
    }
}
