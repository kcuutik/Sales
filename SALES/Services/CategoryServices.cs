using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALES.Entities;
using SALES.Repository;

namespace SALES.Services
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Insert(string name, bool isCheck, string description);
        Task<Category> Update(int id, string name, bool isCheck, string description);
        Task<Category> Delete(int id);

    }
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _categoryServices;
        public CategoryServices(ICategoryRepository categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _categoryServices.GetAll();
        }

        public Task<Category> GetById(int id)
        {
            return _categoryServices.GetById(id);
        }

        public Task<Category> Insert(string name, bool isCheck, string description)
        {
            Category ca = new Category();
            ca.Name = name;
            ca.Ischeck = isCheck;
            ca.Description = description;
            ca.CreateDate = DateTime.Now;
            ca.UpdateDate = DateTime.Now;
            ca.CreateUser = 1;
            ca.UpdateUser = 1;
            return _categoryServices.Insert(ca);
        }

        public Task<Category> Update(int id, string name, bool isCheck, string description)
        {
            Category ca = new Category();
            ca.Id = id;
            ca.Name = name;
            ca.Ischeck = isCheck;
            ca.Description = description;
            return _categoryServices.Update(ca);
        }

        public Task<Category> Delete(int id)
        {
            return _categoryServices.Delete(id);
        }
    }
}
