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
        private readonly ContentstackClient _ContentStackClient;
        private const string _ApiKey = "blt9f51cf96193f91b8";
        private const string _AccessToken = "cs996c7e6b8035dae907649cca";
        private const string _Environment = "poc_test";
        public ContentStackController()
        {
            ContentstackOptions options = new ContentstackOptions()
            {
                ApiKey = _ApiKey,
                AccessToken = _AccessToken,
                Environment = _Environment,
            };
            _ContentStackClient = new ContentstackClient(options);
        }
        public Task<T> Get<T>(string ContentType, string Entry)
        {
            return _ContentStackClient.ContentType(ContentType).Entry(Entry).Fetch<T>();
        }
    }
}
