using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SALES.Entities;
using SALES.Models;
using SALES.Services;

namespace SALES.Controllers
{
    public class AdminImgeController : Controller
    {

        private readonly IImageServices _imageServices;
        private readonly IProductServices _productServices;
        public AdminImgeController(IImageServices imageServices, IProductServices productServices)
        {
            _imageServices = imageServices;
            _productServices = productServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAll()
        {
            var pro = await _imageServices.GetAll();
            return PartialView("_List", pro);
        }

        public async Task<IActionResult> FormInsert()
        {
            var pro = await _productServices.GetAll();


            ViewBag.Product = pro.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return PartialView("_FormInsert", new Image());
        }

        [HttpPost]
        public async Task<JsonResult> Insert(Image img)
        {
            var i = await _imageServices.Insert(img);
            return Json(new { isSuccess = true });
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var i = await _imageServices.Delete(id);
            return Json(new { isSuccess = true });
        }

        [HttpPost]
        public string UploadFiles()
        {
            var file = Request.Form.Files;
            int ProductId = Convert.ToInt32(Request.Form["productId"].ToString());
            string Name = Request.Form["name"].ToString();
            
            if (file.Count > 0)
            {
                foreach (var f in file)
                {
                    string imgran = GetRandomAlphanumericString(10);
                    var folderName = Path.Combine("wwwroot", "admin/img/product");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                    var fileName = ContentDispositionHeaderValue.Parse(f.ContentDisposition).FileName.Trim('"');
                    var fileNameNew = imgran + "" + fileName.Substring(fileName.Length - 4);
                    var fullPath = Path.Combine(pathToSave, fileNameNew);
                    var dbPath = Path.Combine(folderName, fileNameNew);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        f.CopyTo(stream);
                    }
                    Image img = new Image();
                    img.ProductId = ProductId;
                    img.Url = "/admin/img/product/" + fileNameNew;
                    img.Name = Name;
                    img.CreateDate = DateTime.Now;
                    img.UpdateDate = DateTime.Now;
                    img.CreateUser = 1;
                    img.UpdateUser = 1;
                    _imageServices.Insert(img);
                }
            }
            return "khoa nè";
        }

        [HttpPost]
        public string UploadImageProduct()
        {
            var file = Request.Form.Files;
            int ProductId = Convert.ToInt32(Request.Form["productId"].ToString());

            if (file.Count > 0)
            {
                foreach (var f in file)
                {
                    string imgran = GetRandomAlphanumericString(10);
                    var folderName = Path.Combine("wwwroot", "admin/img/product");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                    var fileName = ContentDispositionHeaderValue.Parse(f.ContentDisposition).FileName.Trim('"');
                    var fileNameNew = imgran +""+ fileName.Substring(fileName.Length - 4);
                    var fullPath = Path.Combine(pathToSave, fileNameNew);
                    var dbPath = Path.Combine(folderName, fileNameNew);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        f.CopyTo(stream);
                    }
                    _productServices.UpdateImages(ProductId, "/admin/img/product/" + fileNameNew);
                }
            }
            return "khoa nè";
        }

        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }
    }
}