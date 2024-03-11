using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class StateController : Controller
    {
        
        public IActionResult set()
        {
            TempData["Name"] = "Hussein";
            return Content("Data Saved");
        
        
        }
        
        /*public IActionResult get1()
        {
            string Name = TempData["Name"].ToString();
            return Content($"get1 call and tempdata = \"{Name}\"");
        }*/
        
        /*public IActionResult get1()
        {
            string Name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }
            return Content($"get1 call and tempdata = \"{Name}\"");
        }*/

        public IActionResult get1()
        {
            string Name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
                TempData.Keep("Name");
            }
            return Content($"get1 call and tempdata = \"{Name}\"");
        }
        
        public IActionResult get2()
        {
            string Name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                Name = TempData.Peek("Name").ToString();
            }          
            return Content($"get2 call and tempdata = \"{Name}\"");
        }

        public IActionResult setState()
        {
            string Name = "Hussein";
            int age = 20;
            HttpContext.Session.SetString("stdName", Name);//per client
            HttpContext.Session.SetInt32("stdAge", age);//per client
            //Deleted when close the browser or the time set was fifshes
            return Content("Save");
        }
        public IActionResult getState()
        {
            string s = HttpContext.Session.GetString("stdName");
            int age =(int) HttpContext.Session.GetInt32("stdAge");
            return Content($"get success {s}, Age = {age}");
        }


        public IActionResult setCookie()
        {
            Response.Cookies.Append("username", "Hussein");
            return Content("Cookie saved");
        }
        
        public IActionResult setCookie2()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(2);//for 2 more days
            Response.Cookies.Append("username", "Hussein",cookieOptions);
            return Content("Cookie saved");
        }

        public IActionResult getCookie()
        {
            string uname = Request.Cookies["username "].ToString();
            string color = Request.Cookies["color"].ToString();
            return Content(uname + " " + color);
        }
    }

}
