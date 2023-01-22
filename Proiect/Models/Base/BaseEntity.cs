using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proiect.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //genereaza automat cand adaugam un obiect nou
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public DateTime? DateCreated { get; set; }
    }
}
