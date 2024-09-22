using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Kategoria
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Kategoria Name")]
        public string Name { get; set; }
        public ICollection<Pleylist> Pleylists { get; set; }
    }
}