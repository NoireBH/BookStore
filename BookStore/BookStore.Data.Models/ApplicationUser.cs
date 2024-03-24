using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
	public class ApplicationUser : IdentityUser
	{
        public ApplicationUser()
        {
            Orders = new HashSet<Order>();
        }

        public ICollection<Order> Orders { get; set; } = null!;
	}
}
