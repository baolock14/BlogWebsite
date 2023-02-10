using System;
using System.Collections.Generic;

#nullable disable

namespace BlogWebDemo.Models
{
    public partial class News
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Scontents { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool? Published { get; set; }
        public string Alias { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Author { get; set; }
        public int AccountId { get; set; }
        public string Tag { get; set; }
        public int CatId { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsNewFeed { get; set; }

        public virtual Account Account { get; set; }
        public virtual Category Cat { get; set; }
    }
}
