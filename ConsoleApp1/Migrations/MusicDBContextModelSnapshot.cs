﻿// <auto-generated />
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(MusicDBContext))]
    partial class MusicDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp1.Entities.Albom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Albom Name");

                    b.Property<int>("Reiting")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            GenreId = 1,
                            Name = "AN 225",
                            Reiting = 0,
                            Year = 1234
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            GenreId = 2,
                            Name = "AN 225",
                            Reiting = 0,
                            Year = 2345
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            LastName = "BBBBb",
                            Name = "AN 225"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            LastName = "BBBBb",
                            Name = "AN 225"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Country Name");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "FFFF"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CCCC"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Ganr Name");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "WWWWW"
                        },
                        new
                        {
                            Id = 2,
                            Name = "EEEEE"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Kategoria Name");

                    b.HasKey("Id");

                    b.ToTable("Kategoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "QQQQQ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "RRRRR"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Pleylist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Trek Name");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Pleylist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriaId = 1,
                            Name = "AN 225"
                        },
                        new
                        {
                            Id = 2,
                            KategoriaId = 2,
                            Name = "AN 225"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Trek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbomId")
                        .HasColumnType("int");

                    b.Property<int>("CountProslych")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Trek Name");

                    b.Property<int>("Reiting")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbomId");

                    b.ToTable("Trek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbomId = 1,
                            CountProslych = 0,
                            Duration = 1233,
                            Name = "AN 225",
                            Reiting = 0,
                            Tekst = "AAAAAAAA"
                        },
                        new
                        {
                            Id = 2,
                            AlbomId = 2,
                            CountProslych = 0,
                            Duration = 20024,
                            Name = "AN 225",
                            Reiting = 0,
                            Tekst = "bBBBBBBB"
                        });
                });

            modelBuilder.Entity("PleylistTrek", b =>
                {
                    b.Property<int>("PleylistsId")
                        .HasColumnType("int");

                    b.Property<int>("TreksId")
                        .HasColumnType("int");

                    b.HasKey("PleylistsId", "TreksId");

                    b.HasIndex("TreksId");

                    b.ToTable("PleylistTrek");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Albom", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Artist", "Artist")
                        .WithMany("Alboms")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.Genre", "Genre")
                        .WithMany("Alboms")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Artist", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Pleylist", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Kategoria", "Kategoria")
                        .WithMany("Pleylists")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Trek", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Albom", "Albom")
                        .WithMany("Treks")
                        .HasForeignKey("AlbomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Albom");
                });

            modelBuilder.Entity("PleylistTrek", b =>
                {
                    b.HasOne("ConsoleApp1.Entities.Pleylist", null)
                        .WithMany()
                        .HasForeignKey("PleylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Entities.Trek", null)
                        .WithMany()
                        .HasForeignKey("TreksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Albom", b =>
                {
                    b.Navigation("Treks");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Artist", b =>
                {
                    b.Navigation("Alboms");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Country", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Genre", b =>
                {
                    b.Navigation("Alboms");
                });

            modelBuilder.Entity("ConsoleApp1.Entities.Kategoria", b =>
                {
                    b.Navigation("Pleylists");
                });
#pragma warning restore 612, 618
        }
    }
}
