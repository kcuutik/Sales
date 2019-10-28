using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SALES.Controllers
{
    public class ThanhVienController : Controller
    {
        public IActionResult DangNhap()
        {
            return View();
        }
        public IActionResult DangKy()
        {
            return View();
        }

        public async Task<ActionResult> GetAll()
        {
            return View();
        }
    }
}