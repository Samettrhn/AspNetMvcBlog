using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class UserCategoryController : Controller
    {
        public IActionResult Index(int? id, int? page)
        {
            return View();
        }
    }
}
