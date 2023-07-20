using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
