using Microsoft.EntityFrameworkCore;
using SALES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Repository
{
    public interface IAkUserRepository
    {
        Task<AkUser> SecurityLogin(string username, string password);
    }
    public class AkUserRepository : IAkUserRepository
    {
        private readonly SalesContext _dbContext;
        public AkUserRepository(SalesContext salesContext)
        {
            _dbContext = salesContext;
        }
        public async Task<AkUser> SecurityLogin(string username, string password)
        {
            var user = await _dbContext.AkUsers.Where(x => x.UserName == username && x.Password == password).FirstOrDefaultAsync();
            if(user != null)
                return user;
            return new AkUser();
        }
    }
}
