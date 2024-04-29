using static BookStore.Common.EntityValidationConstants.Author;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Data.Models
{
	public class Author
	{
        public Author()
        {
            Books = new HashSet<Book>();
        }

		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		public ICollection<Book> Books { get; set; } = null!;
	}
}
