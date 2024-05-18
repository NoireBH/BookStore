using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BookStore.Data.Models;

namespace BookStore.Data.Configurations
{
    public class PublisherEntityConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(SeedPublishers());
        }

        private Publisher[] SeedPublishers()
        {

            var publishers = new HashSet<Publisher>();

            Publisher publisher;

            publisher = new Publisher()
            {
                Id = 1,
                Name = "Simon & Schuster"
            };

            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id = 2,
                Name = "Hachette Book Group"
            };

            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id = 3,
                Name = "RazorBill"
            };

            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id = 4,
                Name = "Pocket Books"
            };

            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id = 5,
                Name = "Ernest Cline"
            };

            publishers.Add(publisher);

			publisher = new Publisher()
			{
				Id = 6,
				Name = "Bloomsbury"
			};

			publishers.Add(publisher);

			publisher = new Publisher()
			{
				Id = 7,
				Name = "George Allen & Unwin"
			};

			publishers.Add(publisher);

			publisher = new Publisher()
			{
				Id = 8,
				Name = "VIZ Media"
			};

			publishers.Add(publisher);

			return publishers.ToArray();

        }
    }
}
