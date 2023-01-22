using Proiect.Models.Base;

namespace Proiect.Models.Review
{
    public class Review : BaseEntity, IReview
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Product.Product Product { get; set; }
        public User.User User { get; set; }
    }
}
