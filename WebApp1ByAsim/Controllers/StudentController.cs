using Microsoft.AspNetCore.Mvc;
using WebApp1ByAsim.Models;

namespace WebApp1ByAsim.Controllers
{
    public class StudentController : Controller
    {
        // GET: /Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // If model validation is successful, redirect to another Razor page and display student details
                return RedirectToAction("Details", student);
            }
            else
            {
                // If model validation fails, return to the form with error messages
                return View(student);
            }
        }

        // GET: /Student/Details
        public IActionResult Details(Student student)
        {
            // Implement logic to display student details
            return View(student);
        }

    }
}
