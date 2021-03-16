namespace MyWebApplication.Web.ViewModels.Movies
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class MovieActorInputModel
    {
        [Required]
        public string ActorName { get; set; }

    }
}
