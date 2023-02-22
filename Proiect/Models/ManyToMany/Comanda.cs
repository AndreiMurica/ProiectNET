namespace Proiect.Models.ManyToMany
{
    public class Comanda
    {
        public Guid UserId { get; set; }
        public User.User User { get; set; }

        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
        
    }
}
