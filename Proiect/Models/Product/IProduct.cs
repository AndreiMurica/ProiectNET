using Proiect.Models.Base;
using System.ComponentModel.DataAnnotations;

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
    }
}
