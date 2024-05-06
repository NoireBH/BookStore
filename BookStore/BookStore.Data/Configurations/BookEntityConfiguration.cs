using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BookStore.Data.Models;

namespace BookStore.Data.Configurations
{
    public class BookEntityConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(SeedBooks());

            builder
            .HasMany(b => b.Authors)
            .WithMany(a => a.Books)
            .UsingEntity(
                 ba => ba.HasData(
                     new { BooksId = 1, AuthorsId = 1 },
                     new { BooksId = 2, AuthorsId = 2 },
                     new { BooksId = 3, AuthorsId = 3 },
                     new { BooksId = 4, AuthorsId = 4 },
                     new { BooksId = 5, AuthorsId = 5 }));
        }

        private Book[] SeedBooks()
        {

            var books = new HashSet<Book>();

            Book book;

            book = new Book()
            {
                Id = 1,
                Title = "It",
                Description = "The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself",
                SoldCopies = 0,
                YearOfRelease = 1986,
                PageCount = 1138,
                PublisherId = 1,
                ImagePath = "/images/books/it cover.jpg"

            };

            books.Add(book);

            book = new Book()
            {
                Id = 2,
                Title = "The Witcher Saga",
                Description = "Geralt the Witcher—revered and hated—holds the line against the monsters plaguing humanity in this collection of adventures, the first chapter in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.",
                SoldCopies = 0,
                YearOfRelease = 2020,
                PageCount = 2000,
                PublisherId = 2,
                ImagePath = "/images/books/witcher saga cover.jpg"
            };

            books.Add(book);

            book = new Book()
            {
                Id = 3,
                Title = "13 Reasons Why",
                Description = "Thirteen Reasons Why is a young adult novel written by Jay Asher in 2007, which follows the story of Hannah Baker, a high school freshman, and the thirteen reasons why she has died by suicide.",
                SoldCopies = 0,
                YearOfRelease = 2007,
                PageCount = 320,
                PublisherId = 3,
                ImagePath = "/images/books/13 reasons why cover.jpg"
            };

            books.Add(book);

            book = new Book()
            {
                Id = 4,
                Title = "World of Warcraft: Arthas: Rise of the Lich King",
                Description = "Arthas: Rise of the Lich King is a Warcraft novel by Christie Golden, who is the author of multiple Star Trek and other Warcraft novels. The novel dealing with the progression of Arthas from Prince to the Lich King, was released on April 21, 2009.",
                SoldCopies = 0,
                YearOfRelease = 2007,
                PageCount = 416,
                PublisherId = 4,
                ImagePath = "/images/books/wow arthas cover.jpg"
            };

            books.Add(book);

            book = new Book()
            {
                Id = 5,
                Title = "Ready Player One",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                SoldCopies = 0,
                YearOfRelease = 2011,
                PageCount = 384,
                PublisherId = 5,
                ImagePath = "/images/books/ready player one cover.jpg"
            };

            books.Add(book);

            return books.ToArray();
        }
    }
}
