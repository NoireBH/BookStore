using System.ComponentModel.DataAnnotations;
using static BookStore.Common.EntityValidationConstants.Genre;
namespace BookStore.Data.Models
{
	public class Genre
	{
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        [Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		public ICollection<Book> Books { get; set; } = null!;
	}
}
