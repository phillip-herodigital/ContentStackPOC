using ContentStackPOC.Models;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ContentStackPOC.Controllers
{
    public class DemoController : PageBaseController<DemoPage>
    {
        private const string ContentType = "main_body";
        private const string Entry = "bltb4b007bb0cd52d0a";
        public DemoController() : base(new ContentStackController(), ContentType, Entry) {
            Console.WriteLine("Empty Constructor");
        }
        public DemoController(ContentStackController ContentStackController) : base(ContentStackController, ContentType, Entry) {
            Console.WriteLine("Full Constructor");
        }
        public async Task<ActionResult> Index()
        {
            var model = await GetContent;
            model.main_body_markdown = CommonMark.CommonMarkConverter.Convert(model.main_body_markdown);
            return View(model);
        }
    }
}
