using Contentstack.Core;
using Contentstack.Core.Configuration;
using Contentstack.Core.Models;
using ContentStackPOC.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContentStackPOC.Controllers
{
    public class ContentStackController
    {
        private readonly ContentstackClient ContentStackClient;
        public ContentStackController() {
            var options = new ContentstackOptions()
            {
                ApiKey = "blt9f51cf96193f91b8",
                AccessToken = "cs996c7e6b8035dae907649cca",
                Environment = "poc_test",
            };
            ContentStackClient = new ContentstackClient(options);
        }
        public T Get<T>(string ContentType, string Entry)
        {
            Entry entry = ContentStackClient.ContentType(ContentType).Entry(Entry);
            var result = Util.AsyncUtil.RunSync(entry.Fetch<T>);
            return result;
        }
    }
}
