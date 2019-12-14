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
        private readonly IImageServices _imageServices;
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices, IImageServices imageServices)
        {
            _productServices = productServices;
            _imageServices = imageServices;
        }
        [HttpGet("danh-muc")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("chi-tiet/{id}/{title}")]
        public async Task<IActionResult> Detail(int id, string title="")
        {
            var item = await _imageServices.GetByIdProduct(id);
            ViewBag.item = item;
            var result = _productServices.GetById(id);
            return View(result.Result);
        }

        [HttpGet("loai-san-pham/{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var pro = await _productServices.GetProductByCategory(id);
            return View(pro);
        }

    }
}