using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    { 
        ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getAll()
        {
            List<Department> depts = context.Department.ToList();
             
            return View(depts);
        }
    }
}
