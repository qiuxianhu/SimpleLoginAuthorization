using SimpleLoginAuthorization.BIZ;
using SimpleLoginAuthorization.Common;
using SimpleLoginAuthorization.Models;
using System;
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
        public PermissionFilterAttribute(string permission) : base(permission)
        {

        }
        #endregion

        #region Methods
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext==null)
            {
                throw new ArgumentNullException("httpContext");
            }
            if (!httpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }
            User user = httpContext.User.Identity as User;
            if (user == null)
            {
                return false;
            }
            string[] permissions = base.Permissions;
            if (permissions.Length==0)
            {
                //没有指定访问权限地址的，读取请求URL作为权限地址。
                string path = httpContext.Request.Url.LocalPath;
                if (this.IsSkipValidate(path))
                {
                    //首页，欢迎页排除
                    permissions = new string[] { path };
                }
            }
            return PermissionBIZ.HasPermission(user.ID, permissions, HttpContext.Current.Timestamp);
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            ActionResult result = null;
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                result = JsonManager.GetError(304, "没有获取数据的访问权限!");
            }
            else
            {
                if (!this.IsSkipValidate(filterContext.HttpContext.Request.Url.LocalPath))
                {//首页，欢迎页直接跳转登录页面
                    result = new HttpUnauthorizedResult();
                }
                else
                {
                    // 输出当前的结果
                    ContentResult contentresult = new ContentResult();
                    contentresult.Content = "没有页面访问权限!";
                    contentresult.ContentType = filterContext.HttpContext.Response.ContentType;
                    result = contentresult;
                }
            }
            filterContext.Result = result ?? new HttpUnauthorizedResult();
        }
        private bool IsSkipValidate(String path)
        {
            return "/" != path && !path.StartsWith("/Home/Welcome", StringComparison.CurrentCultureIgnoreCase) && !path.StartsWith("/Home/Index", StringComparison.CurrentCultureIgnoreCase);
        }
        #endregion
    }
}