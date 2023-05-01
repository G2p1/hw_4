using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_4.Controllers
{
    public class StartFormController : Controller
    {
        // GET: StartForm
        public ActionResult Index()
        {
            return View();
        }
        public string Congrats(string name, string email)
        {
            
            return HttpUtility.HtmlEncode("Я, "+name+"("+email+")"+"став розробником ASP .NET");
            
        }
    }
}