using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundoNews.Domain.Models.DataObjects
{
    public class NewsObject
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImgUrl { get; set; }
    }
}
