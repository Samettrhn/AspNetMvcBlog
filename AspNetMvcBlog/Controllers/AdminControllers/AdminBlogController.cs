using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
