using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data.Models;

namespace BookStore.Data.Configurations
{
    public class AuthorEntityConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(SeedAuthors());
        }

        private Author[] SeedAuthors()
        {

            var authors = new HashSet<Author>();

            Author author;

            author = new Author()
            {
                Id = 1,
                Name = "Stephen King",
                ImagePath = "/images/authors/stephenking-sm.jpg",
                Description = "Stephen Edwin King is an American author. Called the \"King of Horror\", he has also explored other genres, among them suspense, crime, science-fiction, fantasy and mystery. He has also written approximately 200 short stories, most of which have been published in collections."
            };

            authors.Add(author);


            author = new Author()
            {
                Id = 2,
                Name = "Andrzej Sapkowski",
                ImagePath = "/images/authors/Andrzej_Sapkowski.jpg",
                Description = "Andrzej Sapkowski is a Polish fantasy writer, essayist, translator and a trained economist. He is best known for his six-volume series of books The Witcher, which revolves around the eponymous \"witcher,\" a monster-hunter, Geralt of Rivia."
            };

            authors.Add(author);

            author = new Author()
            {
                Id = 3,
                Name = "Jay Asher",
                ImagePath = "/images/authors/Jay_asher_2011.jpg",
                Description = "Jay Asher is an American writer and novelist. He is best known for writing the bestselling 2007 book Thirteen Reasons Why."

            };

            authors.Add(author);


            author = new Author()
            {
                Id = 4,
                Name = "Christie Golden",
                ImagePath = "/images/authors/christie_golden.jpg",
                Description = "Christie Golden is an American author. She has written many novels and several short stories in fantasy, horror and science fiction."
            };

            authors.Add(author);

            author = new Author()
            {
                Id = 5,
                Name = "Ernest Cline",				
				Description = "Ernest Christy Cline is an American science fiction novelist, slam poet, and screenwriter. He wrote the novels Ready Player One, Armada, and Ready Player Two and co-wrote the screenplay for the film adaptation of Ready Player One, directed by Steven Spielberg."
            };

            authors.Add(author);

			author = new Author()
			{
				Id = 6,
				Name = "J.K Rowling",
				ImagePath = "/images/authors/J.K.-Rowling-2021.jpg",
				Description = "Joanne Rowling CH OBE FRSL, known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume fantasy series published from 1997 to 2007."
			};

			authors.Add(author);

			author = new Author()
			{
				Id = 7,
				Name = "J.R.R Tolkien",
				ImagePath = "/images/authors/tolkien.jpg",
				Description = "John Ronald Reuel Tolkien CBE FRSL was an English writer and philologist. He was the author of the high fantasy works The Hobbit and The Lord of the Rings. From 1925 to 1945, Tolkien was the Rawlinson and Bosworth Professor of Anglo-Saxon and a Fellow of Pembroke College, both at the University of Oxford."
			};

			authors.Add(author);

			author = new Author()
			{
				Id = 8,
				Name = "Tatsuki Fujimoto",
				ImagePath = "/images/authors/Tatsuki Fujimoto.jpg",
				Description = "Tatsuki Fujimoto is a Japanese manga artist, known for his works Fire Punch and Chainsaw Man."
			};

			authors.Add(author);

			author = new Author()
			{
				Id = 9,
				Name = "Sui Ishida",
				ImagePath = "/images/authors/sui ishida.jpg",
				Description = "Sui Ishida is a Japanese manga artist. He is popularly known for his dark fantasy manga series Tokyo Ghoul and Choujin X."
			};

			authors.Add(author);

			author = new Author()
			{
				Id = 10,
				Name = "Asato Asato",
				ImagePath = "/images/authors/Asato_Asato.jpg",
				Description = "Asato Asato is a female Japanese novelist. The pen name Asato Asato is a combination of her real name and eighty-eight. ."
			};

			authors.Add(author);

			return authors.ToArray();
        }
    }
}