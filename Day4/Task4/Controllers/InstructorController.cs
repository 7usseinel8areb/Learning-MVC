using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    public class InstructorController : Controller
    {
        ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {
            List<Instructor> instructors = context.Instructor.Include(i => i.Department).ToList();
            List<InstructorWithDepartmentName> instructorVM = new List<InstructorWithDepartmentName>();
            foreach (var instructor in instructors)
            {
                InstructorWithDepartmentName x = new InstructorWithDepartmentName()
                {
                    ID = instructor.ID,
                    Name = instructor.Name,
                    Address = instructor.Address,
                    Image = instructor.Image,
                    Salary = instructor.Salary,
                    DepartmentName = instructor.Department.Name,
                };
                instructorVM.Add(x);
            }
            return View(instructorVM);
        }

        public IActionResult Add()
        {
            Instructor instructor = new Instructor();
            ViewBag.Courses = context.Course.ToList();
            ViewBag.Departments = context.Department.ToList();
            return View(instructor);
        }

        public IActionResult Edit(int id)
        {
            Instructor instructor = context.Instructor.FirstOrDefault(i => i.ID == id);
            ViewBag.Departments = context.Department.ToList();
            ViewBag.Courses = context.Course.ToList();
            return View(instructor);
        }
        
        public IActionResult SaveData(Instructor newInstructor)
        {
            bool SalaryChecker = decimal.TryParse(newInstructor.Salary.ToString(), out var Salary) && Salary!=0 && newInstructor.Salary != null;
            if (SalaryChecker && newInstructor.Name != null && newInstructor.Address != null)
            {
                context.Instructor.Add(newInstructor);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Departments = context.Department.ToList();
            ViewBag.Courses = context.Course.ToList();
            return View("Add",newInstructor);
        }
    }
}
