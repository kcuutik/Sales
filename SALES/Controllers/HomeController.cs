using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SALES.Services;

namespace WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IProductServices _productServices;
        public HomeController(ICategoryServices categoryServices, IProductServices productServices)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;

        }
        [Route("")]
        [Route("trang-chu")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("gioi-thieu")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult GetCatagory()
        {
            var result = _categoryServices.GetAll();
            return PartialView("_List", result.Result);
        }

        [Route("getIsTrend")]
        public IActionResult GetIsTrend()
        {
            var result = _productServices.GetIsTrend();
            return PartialView("_ListTrend", result.Result);
        }

    }
}