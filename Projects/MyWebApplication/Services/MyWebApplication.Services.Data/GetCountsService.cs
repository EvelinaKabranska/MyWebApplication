namespace MyWebApplication.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MyWebApplication.Data.Common.Repositories;
    using MyWebApplication.Data.Models;
    using MyWebApplication.Services.Data.Models;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IDeletableEntityRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Actor> actorsRepository;
        private readonly IDeletableEntityRepository<Movie> moviesRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IDeletableEntityRepository<Image> imagesRepository,
            IDeletableEntityRepository<Actor> actorsRepository,
            IDeletableEntityRepository<Movie> moviesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imagesRepository;
            this.actorsRepository = actorsRepository;
            this.moviesRepository = moviesRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
                ActorsCount = this.actorsRepository.All().Count(),
                MoviesCount = this.moviesRepository.All().Count(),
            };

            return data;
        }
    }
}
