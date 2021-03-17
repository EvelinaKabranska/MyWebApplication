namespace MyWebApplication.Data.Models
{
    using MyWebApplication.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Movie : BaseDeletableModel<int>
    {
        public Movie()
        {
            this.Actors = new HashSet<MovieActor>();
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan Duration { get; set; }

        public ApplicationUser AddedByUserId { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<MovieActor> Actors { get; set; }
        
        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
