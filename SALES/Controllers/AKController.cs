using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SALES.Entities;
using SALES.Services;

namespace SALES.Controllers
{
    public class AKController : Controller
    {
        private readonly IAkUserServices _akUser;
        public AKController(IAkUserServices akUser)
        {
            _akUser = akUser;
        }
        public IActionResult Login()
        {
            return View(new AkUser());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AkUser akUser)
        {
            var user = await _akUser.SecurityLogin(akUser.UserName, akUser.Password);
            ViewBag.Messages = "";
            if (user.Id != 0)
            {
                var option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Append("EmailEnviado", "true", option);
                var boh = Request.Cookies["EmailEnviado"];

                return RedirectToAction("AKWellcom");
            }
            else
            {
                ViewBag.Messages = "Đăng nhập thất bại";
                return View(new AkUser());
            }
        }

        public IActionResult AKWellcom()
        {
            return View();
        }

        public IActionResult WriteCookies(string setting, string settingValue, bool isPersistent)
        {
            if (isPersistent)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(setting, settingValue, options);
            }
            else
            {
                Response.Cookies.Append(setting, settingValue);
            }
            ViewBag.Message = "Cookie Written Successfully!!!";
            return View("Index");
        }
        public IActionResult ReadCookies()
        {
            ViewBag.FontName = Request.Cookies["fontName"];
            ViewBag.FontSize = Request.Cookies["fontSize"];
            ViewBag.Color = Request.Cookies["color"];

            if (string.IsNullOrEmpty(ViewBag.FontName))
            {
                ViewBag.FontName = "Arial";
            }
            if (string.IsNullOrEmpty(ViewBag.FontSize))
            {
                ViewBag.FontSize = "22px";
            }
            if (string.IsNullOrEmpty(ViewBag.Color))
            {
                ViewBag.Color = "Blue";
            }
            return View();
        }
    }
}