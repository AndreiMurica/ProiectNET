using Proiect.Data;
using Proiect.Models.DTOs.UserDto;
using Proiect.Models.User;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        
        public UserRepository(ProiectContext context) : base(context)
        {
        }

        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(u => u.Username == username);
        }

        public List<UserResponseDTO> GetAllUsers()
        {
            var x = from user in _table
                    select new UserResponseDTO(user, null);

            return x.ToList();
        }
    }
}
