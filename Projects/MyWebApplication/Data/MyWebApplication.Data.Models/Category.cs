namespace MyWebApplication.Data.Models
{
    using MyWebApplication.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Movies = new HashSet<Movie>();
        }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
