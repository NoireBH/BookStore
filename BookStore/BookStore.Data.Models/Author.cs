namespace BookStore.Data.Models
{
	public class Author
	{
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public DateTime DateOfBirth { get; set; }

		public DateTime DateOfDeath { get; set; }

		public ICollection<Book> Books { get; set; } = null!;
	}
}
