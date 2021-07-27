using MundoNews.Models.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundoNews.Services.Int
{
    public interface IManageNews
    {
        List<NewsObject> GetLatestNews();
    }
}
