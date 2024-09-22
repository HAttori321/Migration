using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicDBContext dbContext = new MusicDBContext();

            foreach (var albom in dbContext.Albom)
            {
                Console.WriteLine($"{albom.Name} . {albom.Year} . {albom.GenreId} . {albom.ArtistId}");
            }

            foreach (var artist in dbContext.Artist)
            {
                Console.WriteLine($"{artist.Name} . {artist.LastName}. {artist.CountryId}");
            }

            foreach (var country in dbContext.Country)
            {
                Console.WriteLine($"{country.Name}.");
            }

            foreach (var genre in dbContext.Genre)
            {
                Console.WriteLine($"{genre.Name}.");
            }

            foreach (var kategoria in dbContext.Kategoria)
            {
                Console.WriteLine($"{kategoria.Name}.");
            }

            foreach (var pleylist in dbContext.Pleylist)
            {
                Console.WriteLine($"{pleylist.Name}. {pleylist.KategoriaId}");
            }

            foreach (var trek in dbContext.Trek)
            {
                Console.WriteLine($"{trek.Name}. {trek.Duration}. {trek.AlbomId}");
            }
        }
    }
}