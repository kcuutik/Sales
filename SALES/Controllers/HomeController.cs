using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("trang-chu")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo()
        {
            return View();
        }
    }
}