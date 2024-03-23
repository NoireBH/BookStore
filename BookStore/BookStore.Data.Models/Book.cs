namespace BookStore.Data.Models
{
	public class Book
	{
        public Book()
        {
            Authors = new HashSet<Author>();
			Characters = new HashSet<Character>();
        }

        public int Id { get; set; }

		public string Title { get; set; } = null!;

		public string Description { get; set; } = null!;

		public int PublisherId { get; set; }

		public Publisher Publisher { get; set; } = null!;

		public ICollection<Author> Authors { get; set; } = null!;

		public ICollection<Character> Characters { get; set; } = null!;


	}
}
