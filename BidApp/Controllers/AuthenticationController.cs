using System;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using BidApp.Models;
using Microsoft.AspNet.Identity;

namespace BidApp.Controllers
{
    public class AuthenticationController : Controller
    {
        public object DefaultAuthentication { get; private set; }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUri)
        {
            ViewBag.ReturnUrl = returnUri;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(!ValidateUser(model.Login, model.Password))
            {
                ModelState.AddModelError(string.Empty, "Login ou password incorrect");
                return View(model);
            }
            
            var loginClaim = new Claim(ClaimTypes.NameIdentifier, model.Login);
            var claimIdentity = new ClaimsIdentity(new[] { loginClaim }, DefaultAuthenticationTypes.ApplicationCookie);
            var context = Request.GetOwinContext();
            var authenticationManager = context.Authentication;
            authenticationManager.SignIn(claimIdentity);

            if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                return ViewBag.ReturnUrl;

            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public ActionResult Logout()
        {
            var context = Request.GetOwinContext();
            var authenticationManager = context.Authentication;
            authenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

        private bool ValidateUser(string login, string password)
        {
            if (login.Length != 0 && password.Equals("password"))
                return true;
            return false;
        }
    }
}