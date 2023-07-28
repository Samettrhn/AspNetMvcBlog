using Microsoft.AspNetCore.Mvc;

namespace RenderBodyOrnek.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
