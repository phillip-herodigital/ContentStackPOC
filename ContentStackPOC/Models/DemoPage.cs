using Contentstack.Core.Models;
using ContentStackPOC.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ContentStackPOC.Models
{
    public class DemoPage : ContentBase<DemoPage.ContentStackContent>
    {
        public DemoPage(ContentStackController ContentStackController, string ContentType, string Entry) : base(ContentStackController, ContentType, Entry) { }
        public class ContentStackContent {
            public string title { get; set; }
            public string main_body_content { get; set; }
        }
    }
}