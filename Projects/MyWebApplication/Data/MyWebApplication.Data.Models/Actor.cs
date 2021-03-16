namespace MyWebApplication.Data.Models
{
    using MyWebApplication.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Actor : BaseDeletableModel<int>
    {
        public Actor()
        {
            this.Movies = new HashSet<MovieActor>();
        }

        public string Name { get; set; }

        public ICollection<MovieActor> Movies { get; set; }
    }
}
