﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class UserBlogController : Controller
    {
        public IActionResult Search(string? query, int? page)
        {
            return View();
        }

        public IActionResult Detail(int? id)
        {
            return View();
        }
    }
}
