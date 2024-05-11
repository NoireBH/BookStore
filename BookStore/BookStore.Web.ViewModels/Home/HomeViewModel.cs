using BookStore.Services.Mapping;
using BookStore.Web.ViewModels.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.ViewModels.Home
{
    public class HomeViewModel
    {
        public ICollection<BookViewModel> NewBooks { get; set; } = null!;

        public ICollection<BookViewModel> BestSellers { get; set; } = null!;

        public ICollection<BookViewModel> DiscountedBooks { get; set; } = null!;
    }
}
