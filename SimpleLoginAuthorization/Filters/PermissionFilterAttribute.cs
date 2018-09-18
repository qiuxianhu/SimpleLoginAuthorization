using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleLoginAuthorization
{
    [AttributeUsage(AttributeTargets.Method,Inherited =true,AllowMultiple =true)]
    public class PermissionFilterAttribute: AuthorizeFilterAttribute
    {
        #region Constructors
        public PermissionFilterAttribute(params string[] permissions):base(permissions)
        {

        }
        #endregion
    }
}