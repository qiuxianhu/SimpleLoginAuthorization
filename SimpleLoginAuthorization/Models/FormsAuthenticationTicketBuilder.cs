using System;
using System.Web.Security;

namespace SimpleLoginAuthorization.Models
{
    public class FormsAuthenticationTicketBuilder
    {
        /// <summary>
        /// 该值可以控制客户端所有的缓存Cookies是否失效。
        /// 注意：该值只能累加
        /// </summary>
        public static readonly int TicketVersion = 4;
        public static FormsAuthenticationTicket CreateAuthenticationTicket(User user)
        {
            return new FormsAuthenticationTicket(
                TicketVersion,
                user.Name,
                DateTime.Now,
                DateTime.Now.Add(FormsAuthentication.Timeout),
                false,
                user.Serialize()
                );
        }
    }
}