using BlogWebDemo.Enums;
using BlogWebDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebDemo.Controllers.Components
{
    public class PopularViewComponent : ViewComponent
    {
        private readonly dbBlogsContext _context;
        private IMemoryCache _memoryCache;
        public PopularViewComponent(dbBlogsContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }
        public IViewComponentResult Invoke()
        {
            var _tinseo = _memoryCache.GetOrCreate(CacheKeys.Categories, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsNews();
            });
            return View(_tinseo);
        }
        public List<News> GetlsNews()
        {
            List<News> lstins = new List<News>();
            lstins = _context.News.Where(x => x.Published == true)
                                        .Take(6)
                                        .ToList();
            return lstins;
        }

    }
}
