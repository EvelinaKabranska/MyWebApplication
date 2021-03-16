namespace MyWebApplication.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyWebApplication.Services.Data;
    using MyWebApplication.Web.ViewModels.Movies;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MoviesController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly IMoviesService moviesService;

        public MoviesController(
            ICategoriesService categoriesService,
            IMoviesService moviesService)
        {
            this.categoriesService = categoriesService;
            this.moviesService = moviesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateMovieInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMovieInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.moviesService.CreateAsync(input);
            return this.Redirect("/");
        }
    }
}
