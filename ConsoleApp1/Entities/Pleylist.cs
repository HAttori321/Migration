using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Pleylist
    {

        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Trek Name")]
        public string Name { get; set; }
        public ICollection<Trek> Treks { get; set; }
        public Kategoria Kategoria { get; set; }
        public int KategoriaId { get; set; }
    }
}