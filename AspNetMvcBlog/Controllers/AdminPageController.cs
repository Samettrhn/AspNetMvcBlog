using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
