using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.UserControllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
