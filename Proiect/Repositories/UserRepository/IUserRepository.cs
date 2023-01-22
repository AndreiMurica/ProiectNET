using Proiect.Models.User;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);
    }
}
