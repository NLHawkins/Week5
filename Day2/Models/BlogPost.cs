using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }

    public class BlogPostContext: DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}