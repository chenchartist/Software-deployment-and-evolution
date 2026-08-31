using Microsoft.AspNetCore.Mvc;
using WebApplication2_2.Models;

namespace WebApplication2_2.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();
        private static int studentId = 1;

        public IActionResult Index()
        {
            return View(students);
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
                student.Id = studentId++;
                students.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return RedirectToAction("Index");
        }
    }
}