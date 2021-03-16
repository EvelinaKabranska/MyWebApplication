namespace MyWebApplication.Data.Models
{
    using MyWebApplication.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieActor : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
