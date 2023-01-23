using Proiect.Models.Base;
using Proiect.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Proiect.Models.User
{
    public interface IUser : IBaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [JsonIgnore]
        public string PasswordHash { get; set; }
        [Required]
        public Role Role { get; set; }
        
        public List<Product.Product> Istoric { get; set; }

        public List<Review.Review> Reviews { get; set; }
    }
}
