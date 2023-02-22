using Microsoft.EntityFrameworkCore;
using Proiect.Models.ManyToMany;
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
        public DbSet<Comanda> Comenzi { get; set; }

        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e => e.HasIndex(x => x.Username).IsUnique());
            modelBuilder.Entity<User>(e => e.HasIndex(x => x.Email).IsUnique());
            modelBuilder.Entity<Product>(e => e.HasIndex(x => x.Name).IsUnique());

            modelBuilder.Entity<User>()
                 .HasMany(u => u.Reviews)
                 .WithOne(r => r.User);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Product);

            modelBuilder.Entity<Comanda>()
                .HasKey(c => new { c.UserId, c.ProductId });

            modelBuilder.Entity<Comanda>()
                .HasOne(c => c.User)
                .WithMany(u => u.Istoric)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Comanda>()
                .HasOne(c => c.Product)
                .WithMany(p => p.CumparatDe)
                .HasForeignKey(c => c.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
