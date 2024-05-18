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
                     new { BooksId = 12, AuthorsId = 6 },
                     new { BooksId = 13, AuthorsId = 7 },
                     new { BooksId = 14, AuthorsId = 7 },
                     new { BooksId = 15, AuthorsId = 7 },
                     new { BooksId = 16, AuthorsId = 7 },
                     new { BooksId = 17, AuthorsId = 8 },
                     new { BooksId = 18, AuthorsId = 8 },
                     new { BooksId = 19, AuthorsId = 9 },
                     new { BooksId = 20, AuthorsId = 10 }
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
				Description = "Harry has been burdened with a dark, dangerous and seemingly impossible task: that of locating and destroying Voldemort's remaining Horcruxes. Never has Harry felt so alone, or faced a future so full of shadows. But Harry must somehow find within himself the strength to complete the task he has been given. He must leave the warmth, safety and companionship of The Burrow and follow without fear or hesitation the inexorable path laid out for him...In this final, seventh installment of the Harry Potter series, J.K. Rowling unveils in spectacular fashion the answers to the many questions that have been so eagerly awaited.",
				SoldCopies = 0,
				YearOfRelease = 2007,
				PageCount = 759,
				PublisherId = 6,
				ImagePath = "/images/books/Deathly Hallows.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 13,
				Title = "The Hobbit",
				Description = "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort.\r\nWritten for J.R.R. Tolkien’s own children, The Hobbit met with instant critical acclaim when it was first published in 1937. Now recognized as a timeless classic, this introduction to the hobbit Bilbo Baggins, the wizard Gandalf, Gollum, and the spectacular world of Middle-earth recounts of the adventures of a reluctant hero, a powerful and dangerous ring, and the cruel dragon Smaug the Magnificent. The text in this 372-page paperback edition is based on that first published in Great Britain by Collins Modern Classics (1998), and includes a note on the text by Douglas A. Anderson (2001).",
				SoldCopies = 0,
				YearOfRelease = 1937,
				PageCount = 366,
				PublisherId = 7,
				ImagePath = "/images/books/the hobbit.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 14,
				Title = "The Fellowship of the Ring",
				Description = "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nIn ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit.\r\n\r\nIn a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bilbo entrusts the Ring to his care. Frodo must leave his home and make a perilous journey across Middle-earth to the Cracks of Doom, there to destroy the Ring and foil the Dark Lord in his evil purpose.",
				SoldCopies = 0,
				YearOfRelease = 1954,
				PageCount = 432,
				PublisherId = 7,
				ImagePath = "/images/books/The Fellowship of the Ring.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 15,
				Title = "The Two Towers",
				Description = "Begin your journey into Middle-earth.\r\n\r\nThe inspiration for the upcoming original series on Prime Video, The Lord of the Rings: The Rings of Power.\r\n\r\nThe Two Towers is the second part of J.R.R. Tolkien’s epic adventure The Lord of the Rings.\r\n\r\nOne Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nFrodo and his Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom. They have lost the wizard, Gandalf, in a battle in the Mines of Moria. And Boromir, seduced by the power of the Ring, tried to seize it by force. While Frodo and Sam made their escape, the rest of the company was attacked by Orcs. Now they continue the journey alone down the great River Anduin—alone, that is, save for the mysterious creeping figure that follows wherever they go.",
				SoldCopies = 0,
				YearOfRelease = 1954,
				PageCount = 432,
				PublisherId = 7,
				ImagePath = "/images/books/the two towers.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 16,
				Title = "The Return of the King",
				Description = "Begin your journey into Middle-earth.\r\n\r\nThe inspiration for the upcoming original series on Prime Video, The Lord of the Rings: The Rings of Power.\r\n\r\nThe Return of the King is the third part of J.R.R. Tolkien’s epic adventure The Lord of the Rings.\r\n\r\nOne Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nThe Dark Lord has risen, and as he unleashes hordes of Orcs to conquer all Middle-earth, Frodo and Sam struggle deep into his realm in Mordor.\r\n\r\nTo defeat Sauron, the One Ring must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. The Ring corrupts all who bear it and Frodo’s time is running out.\r\n\r\nWill Sam and Frodo succeed, or will the Dark Lord rule Middle-earth once more?",
				SoldCopies = 0,
				YearOfRelease = 1955,
				PageCount = 432,
				PublisherId = 7,
				ImagePath = "/images/books/the return of the king.jpg",
				Price = 25
			};

			books.Add(book);

			book = new Book()
			{
				Id = 17,
				Title = "Chainsaw Man Box Set",
				Description = "Denji has a simple dream—to live a happy and peaceful life, spending time with a girl he likes. This is a far cry from reality, however, as Denji is forced by the yakuza into killing devils in order to pay off his crushing debts. Using his pet devil Pochita as a weapon, he is ready to do anything for a bit of cash.\r\n\r\nUnfortunately, he has outlived his usefulness and is murdered by a devil in contract with the yakuza. However, in an unexpected turn of events, Pochita merges with Denji's dead body and grants him the powers of a chainsaw devil. Now able to transform parts of his body into chainsaws, a revived Denji uses his new abilities to quickly and brutally dispatch his enemies. Catching the eye of the official devil hunters who arrive at the scene, he is offered work at the Public Safety Bureau as one of them. Now with the means to face even the toughest of enemies, Denji will stop at nothing to achieve his simple teenage dreams.",
				SoldCopies = 0,
				YearOfRelease = 2023,
				PageCount = 2109,
				PublisherId = 8,
				ImagePath = "/images/books/chainsawman-collection.jpg",
				Price = 75
			};

			books.Add(book);

			book = new Book()
			{
				Id = 18,
				Title = "Goodbye Eri",
				Description = "Suffering from a terminal illness, Yuuta's mother asks him to film her last moments, which he does. From her radiant smile when she is with her family to the times when sickness ravages her body in the hospital, he records hours upon hours of footage. After her passing, Yuuta compiles her life into a movie to screen at his school, deciding to add a bit of fantasy to the ending of his film, Dead Explosion Mother, with a literal explosion!\r\n\r\nFollowing the backlash caused by his supposedly tone-deaf portrayal of his mother's death, Yuuta trudges to the hospital roof to take his own life—but there, he meets a girl named Eri. Captivated by his film, Eri requests Yuuta to make a new one that will blow the previous out of the water and prove his critics wrong. The movie they set out to make will stand apart by blurring the line between fact and fiction. And of course, it wouldn't be a Yuuta film if it didn't have his personal flavor—just a dash of fantasy.",
				SoldCopies = 0,
				YearOfRelease = 2022,
				PageCount = 208,
				PublisherId = 8,
				ImagePath = "/images/books/goodbye eri.jpg",
				Price = 26.99
			};

			books.Add(book);

			book = new Book()
			{
				Id = 19,
				Title = "Tokyo Ghoul Box Set",
				Description = "Ghouls live among us, the same as normal people in every way-except for their craving for human flesh.\r\n\r\nA box set that includes all fourteen volumes of the original Tokyo Ghoul series. Includes an exclusive double-sided poster.\r\n\r\nKen Kaneki is an ordinary college student until a violent encounter turns him into the first half-human, half-Ghoul hybrid. Trapped between two worlds, he must survive Ghoul turf wars, learn more about Ghoul society and master his new powers.",
				SoldCopies = 0,
				YearOfRelease = 2018,
				PageCount = 2904,
				PublisherId = 8,
				ImagePath = "/images/books/tokyo ghoul box set.jpg",
				Price = 115
			};

			books.Add(book);

			book = new Book()
			{
				Id = 20,
				Title = "86 Vol. 1",
				Description = "Nine years ago, the Empire of Giad declared war on all neighboring countries using an army of autonomous drones known as the Legion. Threatened by the soulless killing machines, the Republic of San Magnolia, home to the silver-haired Alba race, evacuated its citizens inside 85 districts and developed supposedly unmanned drones known as Juggernauts to counter the Legion. Even after years of war, the Republic boasts that they have suffered zero casualties. However, the battlefield bathed in crimson recites a different melody...\r\n\r\nThe hand dealt to the Colorata people—a minority forced into living in the \"nonexistent\" 86th district—is one of utter contempt and scorn. Looked upon as human filth, they are ordered to pilot the Juggernauts as Processors under the command of Republican Handlers.\r\n\r\nVladilena Milizé, a republican soldier with a strong sense of justice, detests the way her countrymen treat the 86. When she is assigned to the Spearhead Squadron as their handler, she meets a group of oddballs and eventually grows attached to them—particularly their captain, Shinei Nouzen, a boy with a pure sense of purpose and resolve. However, the path they walk is one riddled with death, and growing close to an 86 may have just set Vladilena down a path of despair..",
				SoldCopies = 0,
				YearOfRelease = 2017,
				PageCount = 309,
				PublisherId = 8,
				ImagePath = "/images/books/86 vol 1.jpg",
				Price = 16.99
			};

			books.Add(book);

			return books.ToArray();
        }
    }
}
