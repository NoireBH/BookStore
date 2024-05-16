using BookStore.Data.Models;
using BookStore.Services.Mapping;

namespace BookStore.Web.ViewModels.Authors
{
	public class AuthorViewModel : IMapFrom<Author>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
