//using BOB.DO.Request.ClientFlow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALES.Entities;

namespace SALES.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> GetIsActive();
        Task<Product> GetById(int id);
        Task<Product> Insert(Product pro);
        Task<Product> Update(Product pro);
        Task<Product> Delete(int id);
    }
    public class ProductRepository : IProductRepository
    {
        private readonly SalesContext _dbContext;
        public ProductRepository(SalesContext salesContext)
        {
            _dbContext = salesContext;
        }
        public async Task<List<Product>> GetAll()
        {
            try { return await _dbContext.Products.ToListAsync(); } catch (Exception ex) { return new List<Product>(); }

        }

        public async Task<Product> GetById(int id)
        {
            if (id == 0)
                return new Product();
            return await _dbContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> Insert(Product pro)
        {
            try
            {
                _dbContext.Products.Add(pro);
                _dbContext.SaveChanges();
                return pro;
            }
            catch (Exception ex) { return new Product(); }
        }

        public async Task<Product> Update(Product pro)
        {
            var p = _dbContext.Products.FirstOrDefault(x => x.Id == pro.Id);
            if (p == null)
                return new Product();

            p.CategoryId = pro.CategoryId;
            p.Name = pro.Name;
            p.Title = pro.Title;
            p.PriceIn = pro.PriceIn;
            p.PriceOut = pro.PriceOut;
            p.QuantilyIn = pro.QuantilyIn;
            p.QuantilyOut = pro.QuantilyOut;

            p.Keywords = pro.Keywords;
            p.Description = pro.Description;
            p.Contentt = pro.Contentt;

            p.IsActive = true;
            p.CreateDate = DateTime.Now;
            p.CreateUser = 1;
            p.UpdateDate = DateTime.Now;
            p.UpdateUser = 1;

            _dbContext.SaveChanges();
            return pro;
        }
        public async Task<Product> Delete(int id)
        {
            var pro = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            if (pro != null)
            {
                _dbContext.Products.Remove(pro);
                _dbContext.SaveChanges();
            }

            return pro;
        }

        public async Task<List<Product>> GetIsActive()
        {
            return await _dbContext.Products.Where(x => x.IsActive == true).ToListAsync(); 
        }
    }
}
