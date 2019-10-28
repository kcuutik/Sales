using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SALES.Entities;
using SALES.Services;

namespace SALES.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        public AdminCategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAll()
        {
            List<Category> ca = await _categoryServices.GetAll();
            return PartialView("_List", ca);
        }

        public async Task<JsonResult> Insert(int id, string name, bool isCheck, string description)
        {
            
            var c = await _categoryServices.Insert(name, isCheck, description);
            return Json(new { isSuccess = true });
        }

        public async Task<JsonResult> Update(int id, string name, bool isCheck, string description)
        { 
            var c = await _categoryServices.Update(id, name, isCheck, description);
            return Json(new { isSuccess = true });
        }

        public async Task<JsonResult> Delete(int id)
        {
            var c = await _categoryServices.Delete(id);
            return Json(new { isSuccess = true });
        }
    }
}