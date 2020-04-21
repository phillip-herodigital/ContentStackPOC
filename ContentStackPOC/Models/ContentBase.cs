using Contentstack.Core;
using Contentstack.Core.Configuration;
using ContentStackPOC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContentStackPOC.Models
{
    public abstract class ContentBase<T>
    {
        public T Content;
        public ContentBase(ContentStackController ContentStackController, string ContentType, string Entry)
        {
            Content = ContentStackController.Get<T>(ContentType, Entry);
        }
    }
}