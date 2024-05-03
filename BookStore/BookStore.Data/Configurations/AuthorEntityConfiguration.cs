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
                Description = "Stephen Edwin King is an American author. Called the \"King of Horror\", he has also explored other genres, among them suspense, crime, science-fiction, fantasy and mystery. He has also written approximately 200 short stories, most of which have been published in collections."
            };

            authors.Add(author);


            author = new Author()
            {
                Id = 2,
                Name = "Andrzej Sapkowski",
                Description = "Andrzej Sapkowski is a Polish fantasy writer, essayist, translator and a trained economist. He is best known for his six-volume series of books The Witcher, which revolves around the eponymous \"witcher,\" a monster-hunter, Geralt of Rivia."
            };

            authors.Add(author);

            author = new Author()
            {
                Id = 3,
                Name = "Jay Asher",
                Description = "Jay Asher is an American writer and novelist. He is best known for writing the bestselling 2007 book Thirteen Reasons Why."

            };

            authors.Add(author);


            author = new Author()
            {
                Id = 4,
                Name = "Christie Golden",
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

            return authors.ToArray();
        }
    }
}