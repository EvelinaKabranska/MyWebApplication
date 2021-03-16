namespace MyWebApplication.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CountsDto
    {
        public int MoviesCount { get; set; }

        public int CategoriesCount { get; set; }

        public int ActorsCount { get; set; }

        public int ImagesCount { get; set; }
    }
}
