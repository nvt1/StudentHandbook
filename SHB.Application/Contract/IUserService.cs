using SHB.Application.Models.Request.User;
using SHB.Domain;

namespace SHB.Application.Contract
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int id);

        Task<User> UpdateUserAsync(int id, UpdateUserRequest updateUserRequest);

        Task<User> CreateUserAsync(CreateUserRequest user);

        Task DeleteUserAsync(int id);
    }

}
