using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        //public ActionResult Index()
        //{


        //    return View();
        //}
        
        public string Index(string id, string name)
        {
            return "The value of id = " + id + " and Name = " + name;
        }

        // Exibindo texto com a controller - Não é recomendado
        public string Texto()
        {
             return "Hello From ASP.NET MVC Application";
        }
    }
}