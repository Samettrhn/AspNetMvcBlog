using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
