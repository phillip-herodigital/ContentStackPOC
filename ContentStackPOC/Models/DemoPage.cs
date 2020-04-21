using System.Collections.Generic;
using System.Web;

namespace ContentStackPOC.Models
{
    public class DemoPage
    {
        public string title { get; set; }
        public string main_body_content { get; set; }
        public string main_body_markdown { get; set; }
        public IEnumerable<string> tags { get; set; }
    }
}