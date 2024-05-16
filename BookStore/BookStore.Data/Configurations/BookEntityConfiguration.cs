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
                     new { BooksId = 5, AuthorsId = 5 },
                     new { BooksId = 6, AuthorsId = 6 },
                     new { BooksId = 7, AuthorsId = 6 },
                     new { BooksId = 8, AuthorsId = 6 },
                     new { BooksId = 9, AuthorsId = 6 },
                     new { BooksId = 10, AuthorsId = 6 },
                     new { BooksId = 11, AuthorsId = 6 },
                     new { BooksId = 12, AuthorsId = 6 }
					 ));
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
                ImagePath = "/images/books/it cover.jpg",
                Price = 12

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
                ImagePath = "/images/books/witcher saga cover.jpg",
                Price = 70.65
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
                ImagePath = "/images/books/13 reasons why cover.jpg",
                Price = 30
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
                ImagePath = "/images/books/wow arthas cover.jpg",
                Price = 20,
               
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
                ImagePath = "/images/books/ready player one cover.jpg",
                Price = 25.65
            };

            books.Add(book);

			book = new Book()
			{
				Id = 6,
				Title = "Harry Potter and the Philosopher's Stone",
				Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school and with the help of his friends, Ron Weasley and Hermione Granger, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
				SoldCopies = 0,
				YearOfRelease = 1997,
				PageCount = 223,
				PublisherId = 6,
				ImagePath = "/images/books/harry_philosopher-stone.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 7,
				Title = "Harry Potter and the Chamber of Secrets",
				Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.\r\n",
				SoldCopies = 0,
				YearOfRelease = 1998,
				PageCount = 352,
				PublisherId = 6,
				ImagePath = "/images/books/Harry Potter and the Chamber of Secrets.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 8,
				Title = "Harry Potter and the Prisoner of Azkaban",
				Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.",
				SoldCopies = 0,
				YearOfRelease = 1999,
				PageCount = 435,
				PublisherId = 6,
				ImagePath = "/images/books/Harry Potter and the Prisoner of Azkaban.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 9,
				Title = "Harry Potter and the Goblet of Fire",
				Description = "It is the summer holidays and soon Harry Potter will be starting his fourth year at Hogwarts School of Witchcraft and Wizardry. Harry is counting the days: there are new spells to be learnt, more Quidditch to be played, and Hogwarts castle to continue exploring.",
				SoldCopies = 0,
				YearOfRelease = 2000,
				PageCount = 734,
				PublisherId = 6,
				ImagePath = "/images/books/Goblet of Fire.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 10,
				Title = "Harry Potter and the Order of the Phoenix",
				Description = "Harry Potter is about to start his fifth year at Hogwarts School of Witchcraft and Wizardry. Unlike most schoolboys, Harry never enjoys his summer holidays, but this summer is even worse than usual. The Dursleys, of course, are making his life a misery, but even his best friends, Ron and Hermione, seem to be neglecting him.",
				SoldCopies = 0,
				YearOfRelease = 2003,
				PageCount = 912,
				PublisherId = 6,
				ImagePath = "/images/books/Order of Phoenix.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 11,
				Title = "Harry Potter and the Half-Blood Prince",
				Description = "It is the middle of the summer, but there is an unseasonal mist pressing against the windowpanes. Harry Potter is waiting nervously in his bedroom at the Dursleys' house in Privet Drive for a visit from Professor Dumbledore himself. One of the last times he saw the Headmaster, he was in a fierce one-to-one duel with Lord Voldemort, and Harry can't quite believe that Professor Dumbledore will actually appear at the Dursleys' of all places. Why is the Professor coming to visit him now? What is it that cannot wait until Harry returns to Hogwarts in a few weeks' time? Harry's sixth year at Hogwarts has already got off to an unusual start, as the worlds of Muggle and magic start to intertwine.",
				SoldCopies = 0,
				YearOfRelease = 2005,
				PageCount = 652,
				PublisherId = 6,
				ImagePath = "/images/books/Half-Blood Prince.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 12,
				Title = "Harry Potter and the Deathly Hallows",
				Description = "Harry has been burdened with a dark, dangerous and seemingly impossible task: that of locating and destroying Voldemort's remaining Horcruxes. Never has Harry felt so alone, or faced a future so full of shadows. But Harry must somehow find within himself the strength to complete the task he has been given. He must leave the warmth, safety and companionship of The Burrow and follow without fear or hesitation the inexorable path laid out for him...\r\n\r\nIn this final, seventh installment of the Harry Potter series, J.K. Rowling unveils in spectacular fashion the answers to the many questions that have been so eagerly awaited.",
				SoldCopies = 0,
				YearOfRelease = 2007,
				PageCount = 759,
				PublisherId = 6,
				ImagePath = "/images/books/Deathly Hallows.jpg",
				Price = 25
			};

			books.Add(book);

			return books.ToArray();
        }
    }
}
