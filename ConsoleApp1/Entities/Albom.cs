using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Albom
    {

        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Albom Name")]
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public ICollection<Trek> Treks { get; }
        public int Reiting { get; set; }
    }
}