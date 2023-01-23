using Proiect.Models.DTOs.UserDto;
using Proiect.Models.User;

namespace Proiect.Services.UserServices
{
    public interface IUserService
    {
        UserResponseDTO Atuhentificate(UserRequestLoginDTO model);
        List<UserResponseDTO> GetAllUsers();
        User GetById(Guid id);
        Task Create(User newUser);
        User Find(string username);
        void DeleteAllFunction();
    }
}
