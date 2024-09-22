using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities
{
    public class Trek
    {

        public int Id { get; set; }
        [Required, MaxLength(100)]
        [Column("Trek Name")]
        public string Name { get; set; }
        public Albom Albom { get; set; }
        public int AlbomId { get; set; }
        public int Duration { get; set; }
        public ICollection<Pleylist> Pleylists { get; set; }
        public int Reiting { get; set; }
        public int CountProslych { get; set; }
        public string Tekst { get; set; }
    }
}