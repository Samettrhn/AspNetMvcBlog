using Microsoft.AspNetCore.Mvc;
using P016_ViewDataTempDataViewBag.Models;
using System.Diagnostics;

namespace P016_ViewDataTempDataViewBag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewData["Mesaj1"] = "ViewData verisi";
            TempData["Mesaj"] = "TempDataVerisi";
            ViewBag.Mesaj = "ViewBag verisi";

            return View();
            //return RedirectToAction("Index2");
        }

        public IActionResult Index2()
        {
            var viewData = ViewData["Mesaj"];
            var viewBag = ViewBag.Mesaj;
            var tempData = TempData["Mesaj"];

            return View();
            //session
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}