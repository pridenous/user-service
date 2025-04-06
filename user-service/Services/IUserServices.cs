using user_service.Models;

namespace user_service.Services
{
    public interface IUserServices
    {
        Task<List<User>> GetUser();
    }
}
