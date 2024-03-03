using Day1_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1_Assignment.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details(int id)
        {
            Student std = StudentList.studens.FirstOrDefault(s => s.ID == id);
            return View("Details",std);
        }
        public IActionResult Index()
        {
            List<Student> stds = StudentList.studens.ToList();
            return View("Index",stds);
        }
    }
}
