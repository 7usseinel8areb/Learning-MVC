using Day3_Assignment.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day3_Assignment.Controllers
{
    ITIEntities context = new ITIEntities();
    public class StudentController : Controller
    {
        public IActionResult StudentDetails(int Id)
        {
            Student stdModel = ActionContext.Student.Include(s => s.Course).Include(c => c.crsResult).FirstOrDefault();


            SudentNameWithCourseNameWithDegree stdVM = new SudentNameWithCourseNameWithDegree();
            stdVM.stdName = stdModel.Name;
            stdVM.crsName = stdModel.crsName;
            stdVM.degree = stdModel.degree;

            return View(stdVM);

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
