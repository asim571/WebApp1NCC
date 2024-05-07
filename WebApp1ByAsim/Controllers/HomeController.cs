using Microsoft.AspNetCore.Mvc;
using WebApp1ByAsim.Models;

namespace WebApp1ByAsim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyRazorPage()
        {
            var student = new Models.Student { StdID = 5, Name = "Asim Ghimire", Address = "Lalitpur", Faculty = "BSc. CSIT" };
            return View(student);
        }
    }
}
