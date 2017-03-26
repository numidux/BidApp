using System.Web.Mvc;

namespace BidApp.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            return View();
        }
    }
}