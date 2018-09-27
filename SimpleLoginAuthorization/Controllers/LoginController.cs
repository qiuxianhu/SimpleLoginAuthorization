using System.Web.Mvc;

namespace SimpleLoginAuthorization.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
    }
}