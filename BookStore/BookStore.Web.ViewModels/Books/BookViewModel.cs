using BookStore.Web.ViewModels.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.ViewModels.Books
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public AuthorViewModel[] Authors { get; set; } = null!; 
    }
}
