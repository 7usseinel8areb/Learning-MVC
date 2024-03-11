using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using WebApplication2.Models;
using WebApplication3.ViewModel;

namespace WebApplication2.Controllers
{
    public class PassDataController : Controller
    {
        ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {
            List<string> Branches = new List<string>();
            Branches.Add("Alexandeia");
            Branches.Add("Damietta");
            Branches.Add("Cairo");
            Branches.Add("Menofia");
            Branches.Add("Mansoura");
            Branches.Add("Assiut");
            Branches.Add("Banha");

            ViewData["AnyKey"]=Branches;
            ViewData["msg"] = "Hello new Controller";

            ViewBag.msg = "Hello";
            ViewBag.date = DateTime.Now.ToString();

            List<Department> depts = new List<Department>();
            return View(depts);
            #region overload
            //name of the view is not the same of the action & the Model is null
            //return View("show All");//The name of the new view 
            //name of the view is not the same of the action & the Model isn't null
            //return View("showAll",depts);
            //name of the view is the same of the action & the Model is null
            //return View();
            //name of the view is the same of the action & the Model isn't null
            //return View(depts);
            #endregion
        }

        public IActionResult ShowStudents()
        {
            List<Student> stdModel = context.Student.Include(s => s.Department).ToList();

            //View Model add using ViewModel
            List<StudentNameWithDepartmentNameViewModel> stdVM = 
                new List<StudentNameWithDepartmentNameViewModel>();
            //take copy from Model and set in ViewModel
            foreach(var item in stdModel)
            {
                StudentNameWithDepartmentNameViewModel student = new StudentNameWithDepartmentNameViewModel()
                {
                    ID = item.ID,
                    StudentName = item.Name,
                    DepartmentName = item.Department.Name
                };
                stdVM.Add(student);
            }
            return View();
        }
        public IActionResult ShowStudentDetails(int id)
        {
            Student stdModel = context.Student.Include(s => s.Department).FirstOrDefault(s => s.ID == id);

            //View Model add using ViewModel
            StudentNameWithDepartmentNameViewModel stdVM = 
                new StudentNameWithDepartmentNameViewModel();
            //take copy from Model and set in ViewModel
            stdVM.ID = stdModel.ID;
            stdVM.StudentName = stdModel.Name;
            stdVM.DepartmentName = stdModel.Department.Name;
            return View(stdVM);
        }
    }
    
}
