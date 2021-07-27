using MundoNews.Models.DataObjects;
using MundoNews.Services.Int;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundoNews.Services.Imp
{
    public class ManageNews : IManageNews
    {
        public List<NewsObject> GetLatestNews()
        {
            List<NewsObject> news = new List<NewsObject>();
            var client = new NewsApiClient("6e60cc2c6f4f470b94f46cde46ce6d43");
            var articlesResponse = client.GetEverything(new EverythingRequest
            {
                Q = "Apple",
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = new DateTime(2021,DateTime.Now.Month,1)
            });
            if(articlesResponse.Status == Statuses.Ok)
            {
                foreach(var article in articlesResponse.Articles)
                {
                    NewsObject noticia = new NewsObject();
                    noticia.Author = article.Author;
                    noticia.Description = article.Description;
                    noticia.Title = article.Title;
                    noticia.Url = article.Url;
                    noticia.ImgUrl = article.UrlToImage;
                    news.Add(noticia);
                }                
            }
            return news;
        }
    }
}
