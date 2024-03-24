using System.ComponentModel.DataAnnotations;
using static BookStore.Common.EntityValidationConstants.Character;

namespace BookStore.Data.Models
{
	public class Character
	{
        public Character()
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

		[MaxLength(NameMaxLength)]
		public string? NickName { get; set; } = null!;

		public ICollection<Book> Books { get; set; } = null!;
	}
}
