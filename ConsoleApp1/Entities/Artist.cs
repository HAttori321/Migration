using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Artist
    {

        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("FirstName")]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        [Column("LastName")]
        public string LastName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Albom> Alboms { get; set; }
    }
}