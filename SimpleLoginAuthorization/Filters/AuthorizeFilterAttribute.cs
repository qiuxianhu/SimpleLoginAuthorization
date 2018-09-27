using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SimpleLoginAuthorization
{
    [AttributeUsage(AttributeTargets.Method,Inherited =true,AllowMultiple =true)]
    public class AuthorizeFilterAttribute: FilterAttribute,IAuthorizationFilter
    {
        private string[] _permissions = null;
        public string[] Permissions
        {
            get
            {
                return this._permissions;
            }
            set
            {
                this._permissions = value ?? new string[0];
            }
        }

        public AuthorizeFilterAttribute(params string[] permissions)
        {
            this._permissions = permissions.ToArray();
        }
        public AuthorizeFilterAttribute(string permission)
        {
            this._permissions = new string[] { permission };
        }
        /// <summary>
        /// 调用这个方法必须是线程安全的,因为它是由线程安全OnCacheAuthorization()方法调用。
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected virtual bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext== null)
            {
                throw new ArgumentNullException("httpContext");
            }
            return httpContext.User.Identity.IsAuthenticated;
        }
        protected virtual void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }               
        /// <summary>
        /// 这个方法必须是线程安全的,由缓存调用。
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected virtual HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            if (httpContext==null)
            {
                throw new ArgumentNullException("httpContext");
            }
            return this.AuthorizeCore(httpContext) ? HttpValidationStatus.Valid : HttpValidationStatus.IgnoreThisRequest;
        }
        private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
        {
            validationStatus = this.OnCacheAuthorization(new HttpContextWrapper(context));
        }
        #region IAuthorizationFilter 方法
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext==null)
            {
                throw new ArgumentNullException("filterContext");
            }
            if (OutputCacheAttribute.IsChildActionCacheActive(filterContext))
            {
                // If a child action cache block is active, we need to fail immediately, even if authorization
                // would have succeeded. The reason is that there's no way to hook a callback to rerun
                // authorization before the fragment is served from the cache, so we can't guarantee that this
                // filter will be re-run on subsequent requests.AuthorizeAttribute Cannot Use Within Child Action Cache
                throw new InvalidOperationException("AuthorizeAttribute Cannot Use Within Child Action Cache");
            }
            //在ASP.NET MVC项目中，一般都要使用身份验证和权限控制，但总有部分网页是允许匿名访问的。使用AllowAnonymous属性就可以
            //指定需要匿名访问的控制器或者Action，从而跳过身份验证。
            //IsDefined该方法接收两个参数，第一个attributeType（自定义特性的类型），第二个参数inherit（要查找继承的自定义特性的
            //层次结构链，则为 true；否则为 false），返回结果（如果为此成员定义了 attributeType，则为 true；否则为 false）。
            //参考博客园https://blog.csdn.net/song_jiang_long/article/details/52605660
            bool skipAuthorization = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), inherit: true)||filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute),inherit:true);
            if (skipAuthorization)
            {
                return;
            }
            if (this.AuthorizeCore(filterContext.HttpContext))
            {
                // ** IMPORTANT **
                // Since we're performing authorization at the action level, the authorization code runs
                // after the output caching module. In the worst case this could allow an authorized user
                // to cause the page to be cached, then an unauthorized user would later be served the
                // cached page. We work around this by telling proxies not to cache the sensitive page,
                // then we hook our custom authorization code into the caching mechanism so that we have
                // the final say on whether a page should be served from the cache.
                HttpCachePolicyBase cachePolicy = filterContext.HttpContext.Response.Cache;
                cachePolicy.SetProxyMaxAge(new TimeSpan(0));
                cachePolicy.AddValidationCallback(this.CacheValidateHandler,null);
            }
            else
            {
                this.HandleUnauthorizedRequest(filterContext);
            }
        }
        #endregion
    }
}