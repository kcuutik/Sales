using Microsoft.EntityFrameworkCore;
using SALES.Entities;
using SALES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Repository
{
    public interface IImageRepository
    {
        Task<List<Image>> GetAll();
        Task<Image> GetById(int id);
        Task<Image> Insert(Image ca);
        Task<Image> Update(Image ca);
        Task<Image> Delete(int id);
    }
    public class ImageRepository : IImageRepository
    {
        private readonly SalesContext _dbContext;
        public ImageRepository(SalesContext salesContext)
        {
            _dbContext = salesContext;
        }

        public async Task<List<Image>> GetAll()
        {
            try
            {
                var img = await _dbContext.Images.Include(x=>x.Product).ToListAsync();
                return img;
            }
            catch (Exception exx) { return new List<Image>(); }
        }

        public Task<Image> GetById(int id)
        {
            return _dbContext.Images.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Image> Insert(Image ca)
        {
            try
            {
                _dbContext.Images.Add(ca);
                _dbContext.SaveChanges();
                return ca;
            }
            catch (Exception ex) { return new Image(); }
        }

        public async Task<Image> Update(Image ca)
        {
            var img = await _dbContext.Images.FirstOrDefaultAsync(x => x.Id == ca.Id);
            if (img != null)
            {
                img.Name = ca.Name;
            }
            _dbContext.SaveChanges();
            return ca;
        }
        public async Task<Image> Delete(int id)
        {
            var img = await _dbContext.Images.FirstOrDefaultAsync(x => x.Id == id);
            if (img != null)
            {
                _dbContext.Remove(img);
                _dbContext.SaveChanges();
            }
            return img;
        }
    }
}
