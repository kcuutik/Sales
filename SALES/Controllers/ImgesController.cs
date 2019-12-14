using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SALES.Services;

namespace SALES.Controllers
{
    [Route("hinh-san-pham")]
    public class ImgesController : Controller
    {
        private readonly IImageServices _imageServices;
        private readonly IProductServices _productServices;
        public ImgesController(IProductServices productServices, IImageServices imageServices)
        {
            _productServices = productServices;
            _imageServices = imageServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("chi-tiet/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var result = _imageServices.GetByIdProduct(id);
            return View(result);
        }
    }
}