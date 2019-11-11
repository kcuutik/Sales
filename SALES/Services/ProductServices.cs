using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALES.Entities;
using SALES.Repository;

namespace SALES.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Insert(Product pro);
        Task<Product> Update(Product pro);
        Task<Product> UpdateImages(int id, string url);
        Task<Product> Delete(int id);
    }
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<Product> Insert(Product pro)
        {
            pro.CreateDate = DateTime.Now;
            pro.UpdateDate = DateTime.Now;
            pro.CreateUser = 1;
            pro.UpdateUser = 1;
            pro.IsActive = true;

            return await _productRepository.Insert(pro);
        }

        public Task<Product> Update(Product pro)
        {
            return _productRepository.Update(pro);
        }
        public Task<Product> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateImages(int id, string url)
        {
            return _productRepository.UpdateImages(id, url);
        }
    }
}
