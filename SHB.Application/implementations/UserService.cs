using AutoMapper;
using SHB.Application.Contract;
using SHB.Application.IRepositories;
using SHB.Application.Models.Request.User;
using SHB.Domain;

namespace SHB.Application.implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<User> CreateUserAsync(CreateUserRequest user)
        {
            var createUser = _mapper.Map<CreateUserRequest, User>(user);
            createUser.FullName = createUser.FirstName + " " + createUser.MiddleName ?? "" + " " + createUser.LastName;
            return await _userRepository.CreateAsync(createUser);
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _userRepository.GetAsync(id);
            if (user != null)
            {
                await _userRepository.DeleteAsync(user);
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> UpdateUserAsync(int id, UpdateUserRequest updateUserRequest)
        {
            var updateUser = await _userRepository.GetAsync(id);
            if (updateUser != null)
            {
                updateUser.StudentCode = updateUserRequest.StudentCode;
                updateUser.FirstName = updateUserRequest.FirstName;
                updateUser.MiddleName = updateUserRequest.MiddleName;
                updateUser.LastName = updateUserRequest?.LastName;
                updateUser.FullName = updateUserRequest?.FullName;
                updateUser.FacultyId = updateUserRequest?.FacultyId;
                updateUser.BirthDay = updateUserRequest?.BirthDay;
                updateUser.ProgramId = updateUserRequest?.ProgramId;
                updateUser.UserTypeId = updateUserRequest?.UserTypeId;
                updateUser.Address = updateUserRequest?.Address;
                updateUser.City = updateUserRequest?.City;
                updateUser.Country = updateUserRequest?.Country;
                updateUser.PostalCode = updateUserRequest?.PostalCode;
                updateUser.Phone = updateUserRequest?.Phone;
                updateUser.Email = updateUserRequest?.Email;
                updateUser.Password = updateUserRequest?.Password;
                updateUser.FieldOfStudyId = updateUserRequest?.FieldOfStudyId;
            }
            return await _userRepository.UpdateAsync(updateUser);
        }
    }
}
