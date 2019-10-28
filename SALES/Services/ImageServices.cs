using SALES.Entities;
using SALES.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Services
{
    public interface IImageServices
    {
        Task<List<Image>> GetAll();
        Task<Image> GetById(int id);
        Task<Image> Insert(Image img);
        Task<Image> Update(Image img);
        Task<Image> Delete(int id);

    }
    public class ImageServices : IImageServices
    {
        private readonly IImageRepository _imageRepository;
        public ImageServices(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        
        public async Task<List<Image>> GetAll()
        {
            return await _imageRepository.GetAll();
        }

        public async Task<Image> GetById(int id)
        {
            return await _imageRepository.GetById(id);
        }

        public async Task<Image> Insert(Image img)
        {
            return await _imageRepository.Insert(img);
        }

        public Task<Image> Update(Image img)
        {
            throw new NotImplementedException();
        }
        public async Task<Image> Delete(int id)
        {
            return await _imageRepository.Delete(id);
        }

    }
}
