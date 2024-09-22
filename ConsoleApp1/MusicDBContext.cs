using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MusicDBContext : DbContext
    {
        public MusicDBContext()
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Albom> Albom { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Trek> Trek { get; set; }
        public DbSet<Pleylist> Pleylist { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=hattoriq1.mssql.somee.com;
                                        packet size=4096;
                                        user id=hattori_SQLLogin_1;
                                        pwd=9s2l522m2p;
                                        data source=hattoriq1.mssql.somee.com;
                                        persist security info=False;
                                        initial catalog=hattoriq1;
                                        TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
            new Country { Id = 1,   Name = "FFFF" },
            new Country { Id = 2,   Name = "CCCC" },
            });
            modelBuilder.Entity<Genre>().HasData(new Genre[]
            {
            new Genre { Id = 1,   Name = "WWWWW" },
            new Genre { Id = 2,   Name = "EEEEE" },
            });
            modelBuilder.Entity<Kategoria>().HasData(new Kategoria[]
            {
            new Kategoria { Id = 1,   Name = "QQQQQ" },
            new Kategoria { Id = 2,   Name = "RRRRR" },
            });
            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
            new Artist { Id = 1,   Name = "AN 225", LastName = "BBBBb", CountryId = 1 },
            new Artist { Id = 2,   Name = "AN 225", LastName = "BBBBb", CountryId = 2 },
            });
            modelBuilder.Entity<Albom>().HasData(new Albom[]
            {
            new Albom { Id = 1,   Name = "AN 225", Year = 1234, GenreId = 1, ArtistId = 1 },
            new Albom { Id = 2,   Name = "AN 225", Year = 2345, GenreId = 2, ArtistId = 2 },
            });
            modelBuilder.Entity<Pleylist>().HasData(new Pleylist[]
            {
            new Pleylist { Id = 1,   Name = "AN 225",  KategoriaId = 1 },
            new Pleylist { Id = 2,   Name = "AN 225",  KategoriaId = 2 },
            });
            modelBuilder.Entity<Trek>().HasData(new Trek[]
            {
            new Trek { Id = 1,   Name = "AN 225", Duration =  1233 , AlbomId = 1, Tekst = "AAAAAAAA" },
            new Trek { Id = 2,   Name = "AN 225", Duration = 20024, AlbomId = 2, Tekst = "bBBBBBBB" },
            });

        }
    }
}