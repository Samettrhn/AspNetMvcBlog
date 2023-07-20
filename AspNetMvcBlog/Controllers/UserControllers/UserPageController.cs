using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.UserControllers
{
    public class UserPageController : Controller
    {
        public IActionResult Detail(int? id)
        {
            return View();
        }
    }
}
