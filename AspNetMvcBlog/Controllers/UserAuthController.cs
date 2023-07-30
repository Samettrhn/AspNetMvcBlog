using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login(string? redirectUrl)
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
