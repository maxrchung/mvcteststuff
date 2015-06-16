using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Comment
    {

        public Comment()
        {
            Date = DateTime.Now;
        }

        public int CommentID { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public int PostID { get; set; }
    }
}