using ContentStackPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentStackPOC.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index(ContentStackController stack)
        { 
            return View(new DemoPage(stack, "main_body", "bltb4b007bb0cd52d0a"));
        }
    }
}
