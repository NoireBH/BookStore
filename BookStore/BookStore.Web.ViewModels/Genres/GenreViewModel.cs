using BookStore.Data.Models;
using BookStore.Services.Mapping;

namespace BookStore.Web.ViewModels.Genres
{
	public class GenreViewModel : IMapFrom<Genre>
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;
	}
}
