using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;

namespace Day3_Assignment.Controllers
{
    public class TestContoller : Controller
    {
        public IActionResult set()
        {
            TempData["Name"] = "Test";
            return Content("Data Saved");
        }
        public IActionResult get()
        {
            string Name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
                TempData.Keep("Name");
            }
            return Content($"get call completed {Name}");
        }
        
        public IActionResult get2()
        {
            string Name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                Name = TempData.Peek("Name").ToString();
            }
            return Content($"get2 call completed {Name}");
        }
        
    }
}
