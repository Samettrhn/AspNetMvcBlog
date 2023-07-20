using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
