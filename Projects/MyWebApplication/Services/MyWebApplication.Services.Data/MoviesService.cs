namespace MyWebApplication.Services.Data
{
    using MyWebApplication.Data.Common.Repositories;
    using MyWebApplication.Data.Models;
    using MyWebApplication.Web.ViewModels.Movies;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MoviesService : IMoviesService
    {
        private readonly IDeletableEntityRepository<Movie> moviesRepository;
        private readonly IDeletableEntityRepository<Actor> actorsRepository;

        public MoviesService(
            IDeletableEntityRepository<Movie> moviesRepository,
            IDeletableEntityRepository<Actor> actorsRepository)
        {
            this.moviesRepository = moviesRepository;
            this.actorsRepository = actorsRepository;
        }

        public async Task CreateAsync(CreateMovieInputModel input)
        {
            var movie = new Movie()
            {
                CategoryId = input.CategoryId,
                Duration = TimeSpan.FromMinutes(input.Duration),
                Description = input.Description,
                Name = input.Name,
            };

            foreach(var inputActor in input.Actors)
            {
                var actor = this.actorsRepository.All().FirstOrDefault(x => x.Name == inputActor.ActorName);
                if (actor == null)
                {
                    actor = new Actor { Name = inputActor.ActorName };
                }

                movie.Actors.Add(new MovieActor
                {
                    Actor = actor,
                });
            }

            await this.moviesRepository.AddAsync(movie);
            await this.moviesRepository.SaveChangesAsync();
        }
    }
}
