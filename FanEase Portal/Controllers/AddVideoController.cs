using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanEase_Portal.Controllers
{
    public class AddVideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddVideoView()
        {
            return View();
        }
    }
}
