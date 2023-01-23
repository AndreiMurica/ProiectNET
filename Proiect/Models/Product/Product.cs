using Proiect.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models.Product
{
    public class Product : BaseEntity, IProduct
    {
        public string Name { get; set; }
        public string Description { get ; set; }
        public decimal Price { get; set ; }
        public string? Category { get ; set ; }
        public User.User Vanzator { get; set; }
        public List<User.User> CumparatDe { get; set; }
        public List<Review.Review> Reviews { get; set; }
        public double Rating
        {
            get
            {
                if (Reviews != null)
                {
                    if (Reviews.Count != 0)
                        return Reviews.Average(r => r.Rating);
                    else
                        return 0;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
