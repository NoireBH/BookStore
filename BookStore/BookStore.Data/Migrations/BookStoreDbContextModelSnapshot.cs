﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Data.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorsId = 1,
                            BooksId = 1
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksId = 2
                        },
                        new
                        {
                            AuthorsId = 3,
                            BooksId = 3
                        },
                        new
                        {
                            AuthorsId = 4,
                            BooksId = 4
                        },
                        new
                        {
                            AuthorsId = 5,
                            BooksId = 5
                        });
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre", (string)null);

                    b.HasData(
                        new
                        {
                            BooksId = 1,
                            GenresId = 6
                        },
                        new
                        {
                            BooksId = 1,
                            GenresId = 8
                        },
                        new
                        {
                            BooksId = 2,
                            GenresId = 5
                        },
                        new
                        {
                            BooksId = 2,
                            GenresId = 6
                        },
                        new
                        {
                            BooksId = 2,
                            GenresId = 13
                        },
                        new
                        {
                            BooksId = 3,
                            GenresId = 5
                        },
                        new
                        {
                            BooksId = 3,
                            GenresId = 11
                        },
                        new
                        {
                            BooksId = 3,
                            GenresId = 12
                        },
                        new
                        {
                            BooksId = 4,
                            GenresId = 6
                        },
                        new
                        {
                            BooksId = 5,
                            GenresId = 7
                        },
                        new
                        {
                            BooksId = 5,
                            GenresId = 12
                        },
                        new
                        {
                            BooksId = 5,
                            GenresId = 13
                        });
                });

            modelBuilder.Entity("BookStore.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Stephen Edwin King is an American author. Called the \"King of Horror\", he has also explored other genres, among them suspense, crime, science-fiction, fantasy and mystery. He has also written approximately 200 short stories, most of which have been published in collections.",
                            Name = "Stephen King"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Andrzej Sapkowski is a Polish fantasy writer, essayist, translator and a trained economist. He is best known for his six-volume series of books The Witcher, which revolves around the eponymous \"witcher,\" a monster-hunter, Geralt of Rivia.",
                            Name = "Andrzej Sapkowski"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Jay Asher is an American writer and novelist. He is best known for writing the bestselling 2007 book Thirteen Reasons Why.",
                            Name = "Jay Asher"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Christie Golden is an American author. She has written many novels and several short stories in fantasy, horror and science fiction.",
                            Name = "Christie Golden"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ernest Christy Cline is an American science fiction novelist, slam poet, and screenwriter. He wrote the novels Ready Player One, Armada, and Ready Player Two and co-wrote the screenplay for the film adaptation of Ready Player One, directed by Steven Spielberg.",
                            Name = "Ernest Cline"
                        });
                });

            modelBuilder.Entity("BookStore.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("SoldCopies")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself",
                            Discount = 0,
                            IsActive = true,
                            PageCount = 1138,
                            PublisherId = 1,
                            SoldCopies = 0,
                            Title = "It",
                            YearOfRelease = 1986
                        },
                        new
                        {
                            Id = 2,
                            Description = "Geralt the Witcher—revered and hated—holds the line against the monsters plaguing humanity in this collection of adventures, the first chapter in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.",
                            Discount = 0,
                            IsActive = true,
                            PageCount = 2000,
                            PublisherId = 2,
                            SoldCopies = 0,
                            Title = "The Witcher Saga",
                            YearOfRelease = 2020
                        },
                        new
                        {
                            Id = 3,
                            Description = "Thirteen Reasons Why is a young adult novel written by Jay Asher in 2007, which follows the story of Hannah Baker, a high school freshman, and the thirteen reasons why she has died by suicide.",
                            Discount = 0,
                            IsActive = true,
                            PageCount = 320,
                            PublisherId = 3,
                            SoldCopies = 0,
                            Title = "13 Reasons Why",
                            YearOfRelease = 2007
                        },
                        new
                        {
                            Id = 4,
                            Description = "Arthas: Rise of the Lich King is a Warcraft novel by Christie Golden, who is the author of multiple Star Trek and other Warcraft novels. The novel dealing with the progression of Arthas from Prince to the Lich King, was released on April 21, 2009.",
                            Discount = 0,
                            IsActive = true,
                            PageCount = 416,
                            PublisherId = 4,
                            SoldCopies = 0,
                            Title = "World of Warcraft: Arthas: Rise of the Lich King",
                            YearOfRelease = 2007
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                            Discount = 0,
                            IsActive = true,
                            PageCount = 384,
                            PublisherId = 5,
                            SoldCopies = 0,
                            Title = "Ready Player One",
                            YearOfRelease = 2011
                        });
                });

            modelBuilder.Entity("BookStore.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Satire"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Poetry"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 10,
                            Name = "History"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Manga"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Light-Novel"
                        });
                });

            modelBuilder.Entity("BookStore.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("BookStore.Data.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Publishers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Simon & Schuster"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hachette Book Group"
                        },
                        new
                        {
                            Id = 3,
                            Name = "RazorBill"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Pocket Books"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ernest Cline"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookStore.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("BookStore.Data.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Data.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("BookStore.Data.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Data.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Data.Models.Book", b =>
                {
                    b.HasOne("BookStore.Data.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookStore.Data.Models.Order", b =>
                {
                    b.HasOne("BookStore.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Data.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStore.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
