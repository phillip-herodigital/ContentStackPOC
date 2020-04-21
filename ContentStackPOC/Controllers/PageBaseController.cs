using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ContentStackPOC.Controllers
{
    public abstract class PageBaseController<T> : Controller
    {
        private readonly ContentStackController _ContentStackController;
        private readonly string _ContentType;
        private readonly string _Entry;
        public PageBaseController(ContentStackController ContentStackController, string ContentType, string Entry)
        {
            _ContentStackController = ContentStackController;
            _ContentType = ContentType;
            _Entry = Entry;
        }
        protected T PageContent { get; set; }
        protected Task<T> GetContent
        {
            get
            {
                return _ContentStackController.Get<T>(_ContentType, _Entry);
            }
        }
    }
}