using Microsoft.EntityFrameworkCore;
using user_service.Base;
using user_service.Models;

namespace user_service.Services
{
    public class UserServices(AppDbContext dbContext) : IUserServices
    {
        public async Task<List<User>> GetUser()
        {
            var user = await dbContext.Users.ToListAsync();
            return user;
        }
    }
}
