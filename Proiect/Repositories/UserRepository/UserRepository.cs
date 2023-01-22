using Proiect.Data;
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
    }
}
