using BookStore.Data.Models;
using BookStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.ViewModels.Authors
{
    public class AuthorViewModel : IMapFrom<Author>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
