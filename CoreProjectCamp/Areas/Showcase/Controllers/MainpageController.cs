using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Showcase.Controllers
{
    [Area("Showcase")]
    [AllowAnonymous]
    public class MainpageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Navbar()
        {
            return PartialView();
        }
    }
}
