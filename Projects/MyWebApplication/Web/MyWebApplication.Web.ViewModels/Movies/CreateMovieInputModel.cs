namespace MyWebApplication.Web.ViewModels.Movies
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CreateMovieInputModel : BaseMovieInputModel
    {
        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<MovieActorInputModel> Actors { get; set; }
    }
}
