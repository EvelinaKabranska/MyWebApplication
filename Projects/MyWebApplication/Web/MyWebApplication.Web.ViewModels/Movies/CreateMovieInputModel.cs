namespace MyWebApplication.Web.ViewModels.Movies
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CreateMovieInputModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }

        [Range(0,10*60)]
        [Display(Name ="Duration (in minutes)")]
        public int Duration { get; set; }

        public string AddedByUserId { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<MovieActorInputModel> Actors { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
