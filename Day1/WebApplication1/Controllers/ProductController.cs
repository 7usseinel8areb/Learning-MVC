using Microsoft.AspNetCore.Mvc;
using Day1.Models;


public class ProductController : Controller
{
    #region Actions
    // write this in the URL 
    //Product/getInfo
    public string getInfo()
    {
        return "Hello from my New MVC Project";
    }
    public ContentResult getContent()
    {
        ContentResult result = new ContentResult();
        result.Content = "Hello from Second action";
        return result;
    }
    //Make Code simple
    /*public ContentResult getContent()
    {
        return Content("Hello from Second action");
    }*/
    
    public ViewResult getView()
    {
        ViewResult result = new ViewResult();
        result.ViewName = "ShowProduct";
        //here it will go to the views and search for a 
        //folder name with the same name of the Controller "Product"
        //if it isn't found in this folder it will search at folder Named shared
        return result ;
    }
    public IActionResult show(int id)
    {
        if(id%2== 0)
        {
            ContentResult result = new ContentResult();
            result.Content = "Even";
            return result;
        }
        else
        {
            ViewResult result = new ViewResult();
            result.ViewName = "ShowProduct";
            return result;
        }
        
    }
    #endregion

    #region Product details
    // product/details/1
    public IActionResult Details(int id)
    {
        Product pro = ProductList.Products.FirstOrDefault( p => p.ID == id);
        return View("Details",pro);
    }
    #endregion

    #region Get All Products
    public IActionResult getAll(int id )
    {
        List<Product> all = ProductList.Products;
        return View("getAll",all);
    }
    #endregion
    public IActionResult Index()
    {
        return View();
    }
}
