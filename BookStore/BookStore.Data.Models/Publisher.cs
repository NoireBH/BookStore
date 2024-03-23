namespace BookStore.Data.Models
{
	public class Publisher
	{
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }

		public string Name { get; set; } = null!;

		public ICollection<Book> Books { get; set; } = null!;
	}
}
