using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Ganr Name")]
        public string Name { get; set; }
        public ICollection<Albom> Alboms { get; set; }
    }
}