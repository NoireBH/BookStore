using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common
{
	public static class EntityValidationConstants
	{
		public class Author
		{
			public const int NameMinLength = 1;
			public const int NameMaxLength = 50;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 10000;
		}

		public class Book
		{
			public const int TitleMinLength = 1;
			public const int TitleMaxLength = 50;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 1000;

			//public const string RatingMin = "1";
			//public const string RatingMax = "10";
		}

        public class  Character 
        {
			public const int NameMinLength = 1;
			public const int NameMaxLength = 50;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 5000;
		}

		public class Genre
		{
			public const int NameMinLength = 2;
			public const int NameMaxLength = 20;
		}

        public class Publisher
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 50;
        }
    }
}
