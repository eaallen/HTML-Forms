using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlFormsTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Sign_up(FormCollection form)
        {
            string name = form["Name"].ToString();
            string email = form["Email address"].ToString();
            string password = form["Password"].ToString();
            
            return "Signing in : "+ "<strong>" + name+ "</strong>"+" <br>with an email address of: "  +"<strong>"+email + "</strong>";

            
        }

    }
}