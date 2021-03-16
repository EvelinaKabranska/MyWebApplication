namespace MyWebApplication.Web.Controllers
{
    using System.Diagnostics;

    using MyWebApplication.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MyWebApplication.Services.Data;
    using MyWebApplication.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countService;

        public HomeController(IGetCountsService countService)
        {
            this.countService = countService;
        }

        public IActionResult Index()
        {
            var counts = this.countService.GetCounts();
            var viewModel = new IndexViewModel
            {
                CategoriesCount = counts.CategoriesCount,
                ImagesCount = counts.ImagesCount,
                ActorsCount = counts.ActorsCount,
                MoviesCount = counts.MoviesCount,
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
