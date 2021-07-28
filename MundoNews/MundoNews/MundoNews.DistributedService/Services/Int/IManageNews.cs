using MundoNews.Domain.Models.DataObjects;
using System.Collections.Generic;

namespace MundoNews.DistributedService.Services.Int
{
    public interface IManageNews
    {
        List<NewsObject> GetLatestNews();
    }
}
