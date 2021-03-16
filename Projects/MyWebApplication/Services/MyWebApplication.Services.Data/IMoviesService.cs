namespace MyWebApplication.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using MyWebApplication.Web.ViewModels.Movies;

    public interface IMoviesService
    {
        Task CreateAsync(CreateMovieInputModel input);
    }
}
