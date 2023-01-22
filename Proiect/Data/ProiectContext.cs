using Microsoft.EntityFrameworkCore;
using Proiect.Models.Product;
using Proiect.Models.Review;
using Proiect.Models.User;

namespace Proiect.Data
{
    public class ProiectContext :  DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        
        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options)
        {
        }
    }
}
