using Proiect.Helper.JwtUtils;
using Proiect.Models.DTOs.UserDto;
using Proiect.Models.User;
using Proiect.Repositories.UserRepository;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Proiect.Services.UserServices
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)  
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }   

        public UserResponseDTO Atuhentificate(UserRequestLoginDTO model)
        {
            var user = _userRepository.FindByUsername(model.UserName);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null; //or throw exception
            }


            // jwt generation
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }

        public List<UserResponseDTO> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public User Find(string username)
        {
            return _userRepository.FindByUsername(username);
        }
        public void DeleteAllFunction()
        {
            _userRepository.DeleteAll();
            _userRepository.Save();
        }
    }
}
