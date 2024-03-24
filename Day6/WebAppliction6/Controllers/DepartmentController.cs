using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DepartmentController : Controller
    {
        ITIEntities context = new ITIEntities();
        public IActionResult TestHelper()
        {
            return View();
        }
        
        public IActionResult Add()
        {
            Department dept = new Department();
            return View(dept);
        }

        public IActionResult SaveAdd(Department newdept)
        {
            if(newdept.Name!=null && newdept.Manager!=null)
            {
                //Save
                context.Department.Add(newdept);
                context.SaveChanges();

                //Display all 
                //return View("Index");//Exception     عشان الفورم دي استرونج تايب طب منا ممكن انده الأكشن نفسه
                return RedirectToAction("Index");
            }
            //Open Add again
            return View("Add",newdept);//newdept عشان ميرجعش الفورم فاضيه
        }


        #region Test
        public IActionResult testBinding(int Id , string Name, int Salary, int[] degree)
        {
            return Content($"Name = {Name}, Salary = {Salary}, Degree = {degree[0]}");
        }

        public IActionResult testBindDict(Dictionary<string, string> Phones)
        {
            return Content(Phones.Values.First().ToString() + Phones.Keys.First().ToString());
        }

        public IActionResult testBindObject(int id, string name, Department dept1)
        {
            return Content("");
        }
        #endregion

        public IActionResult Index()
        {
            List<Department> dptModel = context.Department.ToList();
            return View("Index",dptModel);
        }
    }
}
