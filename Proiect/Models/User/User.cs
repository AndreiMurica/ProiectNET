using Proiect.Models.Base;
using Proiect.Models.Enums;
using Proiect.Models.ManyToMany;

namespace Proiect.Models.User
{
    public class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
        public List<Comanda> Istoric { get ; set ; }
        public List<Review.Review> Reviews { get; set; }
        
    }
}
