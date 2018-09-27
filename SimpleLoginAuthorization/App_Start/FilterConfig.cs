using System.Web.Mvc;

namespace SimpleLoginAuthorization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new PermissionFilterAttribute());//授权控制
        }
    }
}