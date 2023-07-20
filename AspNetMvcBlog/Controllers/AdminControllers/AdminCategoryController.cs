using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.AdminControllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
