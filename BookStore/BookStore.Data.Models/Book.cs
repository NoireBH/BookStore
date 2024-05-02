using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookStore.Common.EntityValidationConstants.Book;

namespace BookStore.Data.Models
{
	public class Book
	{
        public Book()
        {
            Authors = new HashSet<Author>();
			Characters = new HashSet<Character>();
			Genres = new HashSet<Genre>();
        }

		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(TitleMaxLength)]
		public string Title { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Required]
		public int SoldCopies {  get; set; }

		[Required]
		public int PublisherId { get; set; }

		[Required]
		public int YearOfRelease { get; set; }

		[Required]
		public int PageCount { get; set; }

		public bool IsActive { get; set; } = true;

		public int Discount {  get; set; }

		[ForeignKey(nameof(PublisherId))]

		public Publisher Publisher { get; set; } = null!;

		public ICollection<Author> Authors { get; set; } = null!;

		public ICollection<Character> Characters { get; set; } = null!;

		public ICollection<Genre> Genres { get; set; } = null!;


	}
}
