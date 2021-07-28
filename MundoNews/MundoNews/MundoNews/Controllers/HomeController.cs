using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MundoNews.DistributedService.Services.Int;
using MundoNews.Domain.Models;
using MundoNews.Domain.Models.DataObjects;
using System.Collections.Generic;
using System.Diagnostics;

namespace MundoNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IManageNews _news;

        public HomeController(ILogger<HomeController> logger, IManageNews news)
        {
            _logger = logger;
            _news = news;

        }

        public IActionResult Index()
        {
            List<NewsObject> news = _news.GetLatestNews();
            return View(news);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
