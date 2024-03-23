namespace BookStore.Data.Models
{
	public class Character
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public string NickName { get; set; } = null!;
	}
}
