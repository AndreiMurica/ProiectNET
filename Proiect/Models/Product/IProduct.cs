using Proiect.Models.Base;
using Proiect.Models.ManyToMany;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models.Product
{
    public interface IProduct : IBaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? Category { get; set; }
        [Required]
        public User.User Vanzator { get; set; }
        [Required]
        public List<Comanda> CumparatDe { get; set; }
        public List<Review.Review>? Reviews { get; set; }

        [NotMapped]
        public double Rating { get; }

    }
}
