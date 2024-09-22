using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Country Name")]
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }

    }
}