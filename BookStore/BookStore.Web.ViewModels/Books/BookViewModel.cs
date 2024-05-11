using BookStore.Data.Models;
using BookStore.Services.Mapping;
using BookStore.Web.ViewModels.Authors;

namespace BookStore.Web.ViewModels.Books
{
    public class BookViewModel : IMapFrom<Book>
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public double DiscountedPrice { get; set; }

        public virtual AuthorViewModel[] Authors { get; set; } = null!; 
    }
}
