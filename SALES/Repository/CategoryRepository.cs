using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALES.Entities;

namespace SALES.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Insert(Category ca);
        Task<Category> Update(Category ca);
        Task<Category> Delete(int id);
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SalesContext _dbContext;
        public CategoryRepository(SalesContext salesContext)
        {
            _dbContext = salesContext;
        }
        public async Task<List<Category>> GetAll()
        {
            try
            {
                return await _dbContext.Categories.ToListAsync();
            }
            catch (Exception ex) { return new List<Category>(); }
        }

        public async Task<Category> GetById(int id)
        {
            return await _dbContext.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Category> Insert(Category ca)
        {
            _dbContext.Categories.Add(ca);
            _dbContext.SaveChanges();
            return ca;
        }

        public async Task<Category> Update(Category ca)
        {
            var c = _dbContext.Categories.FirstOrDefault(x => x.Id == ca.Id);
            if (c != null)
            {
                c.Name = ca.Name;
                c.Ischeck = ca.Ischeck;
                c.Description = ca.Description;
                c.UpdateDate = DateTime.Now;
            }
            _dbContext.SaveChanges();
            return ca;
        }
        public async Task<Category> Delete(int id)
        {
            var c = _dbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (c != null)
            {
                _dbContext.Categories.Remove(c);
                _dbContext.SaveChanges();
            }

            return c;
        }
    }
}
