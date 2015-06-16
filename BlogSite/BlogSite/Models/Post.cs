using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Post
    {
        public Post()
        {
            Date = DateTime.Now;
        }

        public int PostID { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}