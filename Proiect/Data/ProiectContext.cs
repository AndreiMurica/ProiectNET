using Microsoft.EntityFrameworkCore;
using Proiect.Models.Product;
using Proiect.Models.Review;
using Proiect.Models.User;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e => e.HasIndex(x => x.Username).IsUnique());
            base.OnModelCreating(modelBuilder);
        }
    }
}
