using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
