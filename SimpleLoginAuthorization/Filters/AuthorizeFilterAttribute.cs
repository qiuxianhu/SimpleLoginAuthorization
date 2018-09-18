using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SimpleLoginAuthorization
{
    [AttributeUsage(AttributeTargets.Method,Inherited =true,AllowMultiple =true)]
    public class AuthorizeFilterAttribute: FilterAttribute,IAuthorizationFilter
    {
        #region IAuthorizationFilter 方法
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext==null)
            {
                throw new ArgumentNullException("filterContext");
            }
            if (OutputCacheAttribute.IsChildActionCacheActive(filterContext))
            {

            }
        }
        #endregion
    }
}