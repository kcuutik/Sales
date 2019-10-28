using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SALES.Entities;
using SALES.Services;

namespace WEBAPP.Controllers
{
    [Route("san-pham")]
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        [HttpGet("danh-muc")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("chi-tiet/{id}")]
        public IActionResult Detail(int id)
        {
            return View();
        }

        [HttpGet("getAll")]
        public async Task<ActionResult> GetAll()
        {
            var pro = await _productServices.GetAll();
            return PartialView("_List", pro);
        }

        [HttpGet("getById")]
        public async Task<ActionResult> GetById(int id)
        {
            var pro = await _productServices.GetById(id);
            return PartialView("_Detail", pro);
        }
    }
}