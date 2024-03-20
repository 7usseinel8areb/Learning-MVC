using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
       ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Trainee trainee = context.Trainee.FirstOrDefault(s => s.ID == id);

            List<Department> departments = context.Department.ToList();
            ViewBag.AllDepartments = departments;

            return View(trainee);            
        }

        [HttpPost]//بيمنع ان هو يبعت الداتا في URL --> More Secure
        public IActionResult SaveEdit([FromRoute]int id,Trainee trainee)
        {
            //There must be validation here
            Trainee Edited = context.Trainee.FirstOrDefault(e => e.ID == id);

            Edited.Name = trainee.Name;
            Edited.Address = trainee.Address;   
            Edited.Department_ID = trainee.Department_ID;
            Edited.Image = trainee.Image;
            Edited.Grade = trainee.Grade;
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
