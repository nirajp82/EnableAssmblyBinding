using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrary;
using MyLibrary.Client;
using UtilLib;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> result = new List<string>();

            //try
            //{
            result.AddRange(LibClient.Greet("Raj"));
            result.Add("<br/>");
            result.Add("<br/>");
            result.Add(MyClass.Greet("Raj"));
            result.Add(new MyClass().Greet2("Raj"));
            result.Add(AssemblyExt.GetAssemblyInfo(typeof(MyLibrary.MyClass)));
            //}
            //catch (Exception ex)
            //{
            //    result.Add(ex.ToString());
            //}
            ViewBag.Message = string.Join("<br/> ", result);
            return View();
        }

        public ActionResult About()
        {
            //List<string> result = new List<string>();

            //LibClient.Greet("Heathedge");
            //result.Add(MyLibrary.MyClass.Greet("Heathedge"));
            //result.Add(new MyLibrary.MyClass().Greet2("Heathedge"));
            //result.Add(AssemblyExt.GetAssemblyInfo(typeof(MyLibrary.MyClass)));

            //ViewBag.Message = string.Join("<br/> ", result);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}