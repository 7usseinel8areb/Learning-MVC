using Day2_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_Assignment.Controllers
{
    public class InstructorController : Controller
    {
        ITIEntities ITIEntities = new ITIEntities();
        public IActionResult Index()
        {
            List<Instructor> instructors = ITIEntities.Instructor.ToList();
            return View("Index",instructors);
        }

        public IActionResult getInstructor(int id)
        {
            Instructor instructor = ITIEntities.Instructor.FirstOrDefault(i => i.ID == id);
            return View("getInstructor", instructor);
        }
    }
}
