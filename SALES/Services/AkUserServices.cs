using SALES.Entities;
using SALES.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Services
{
    public interface IAkUserServices
    {
        Task<AkUser> SecurityLogin(string username, string password);
    }
    public class AkUserServices : IAkUserServices
    {
        private readonly IAkUserRepository _akUserRepository;
        public AkUserServices(IAkUserRepository akUserRepository)
        {
            _akUserRepository = akUserRepository;
        }

        public Task<AkUser> SecurityLogin(string username, string password)
        {
            return _akUserRepository.SecurityLogin(username, password);
        }
    }
}
