using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using SALES.Entities;
using SALES.Services;

namespace SALES.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;
        public AdminProductController(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FormInsUp(int id)
        {
            var pro = await _productServices.GetById(id);
            var category = await _categoryServices.GetAll();
            ViewBag.Category = category.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = (x.Id == pro.CategoryId), }).ToList();
            return PartialView("_FormInsUp", pro);
        }

        public async Task<IActionResult> GetAll()
        {
            var pro = await _productServices.GetAll();
            return PartialView("_List", pro);
        }

        [HttpPost]
        public JsonResult InsUp(Product pro)
        {
            if (pro.Id == 0)
                _productServices.Insert(pro);
            else _productServices.Update(pro);

            return Json(new { isSuccess = true });
        }


    }
}