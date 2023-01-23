using Proiect.Models.Base;
using Proiect.Models.Enums;

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
        public List<Product.Product> Istoric { get ; set ; }
        public List<Review.Review> Reviews { get; set; }
        
    }
}
