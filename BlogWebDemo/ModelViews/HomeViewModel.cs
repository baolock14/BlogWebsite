using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebDemo.Models;

namespace BlogWebDemo.ModelViews
{
    public class HomeViewModel
    {
        public List<News> Populars { get; set; }
        public List<News> Inspiration { get; set; }
        public List<News> Recents { get; set; }
        public List<News> Trendings { get; set; }
        public List<News> LastestPosts { get; set; }
        public News Feartured { get; set; }
    }
}
