using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // READ
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                TempData["Success"] = "Student Added Successfully!";

                return RedirectToAction("Index");
            }

            return View(student);
        }

        // EDIT
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        /* // Index
        public string Index()
        {
            return "Welcome to Student Page";
        }

        // Details
        public string Details()
        {
            return "Student Details Page";
        }

        // Parameterized
        public IActionResult GetStudent(int id)
        {
            return Content("Student ID is " + id); 

        public IActionResult Index()
        {
            // Create Student object
            Student student = new Student()
            {
                Id = 1,
                Name = "Kavya",
                Age = 23,
                Email = "kavya@gmail.com"
            };

            return View(student);
        }*/

        /*public IActionResult Index()
        {
            // ViewBag (dynamic)
            ViewBag.StudentName = "Kavya";

            // ViewData (dictionary)
            ViewData["StudentAge"] = 23;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // No DB needed, just for testing
                return Content("Form Submitted Successfully!");
            }

            return View(student);
        }*/
    }
}
