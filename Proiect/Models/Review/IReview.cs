using Proiect.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Proiect.Models.Review
{
    public interface IReview : IBaseEntity
    {
        [Range(1, 5)]
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public Product.Product Product { get; set; }
        [Required]
        public User.User User { get; set; }
    }
}
