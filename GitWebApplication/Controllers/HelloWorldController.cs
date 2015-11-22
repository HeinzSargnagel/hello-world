using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            var hallo = "super freundlich";
            return View();
        }
    }
}