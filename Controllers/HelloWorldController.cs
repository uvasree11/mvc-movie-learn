using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Welcome(string name, int id=1)
        {
            //The ASP.NET MVC model binding system automatically maps the named parameters from the query string in the address bar to parameters in your method.
            //return HttpUtility.HtmlEncode("Hello " + name + ",num is :" + id);//The code uses HttpUtility.HtmlEncode to protect the application from malicious input (namely JavaScript).
            ViewBag.Message = "Hello"+name;
            ViewBag.Id = id;

            return View();
        }
    }
}