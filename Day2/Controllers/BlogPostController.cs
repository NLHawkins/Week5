using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class BlogPostController : Controller
    {
        BlogPostContext db = new BlogPostContext();
        public ActionResult Index()
        {
            using(var db = new BlogPostContext())
            {
                ViewBag.AllBlogPosts = db.BlogPosts.OrderByDescending(x=>x.Created).ToList();
            };
            return View();
        }
        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            using(var db = new BlogPostContext())
            {
                blogPost.Created = DateTime.Now;
                db.BlogPosts.Add(blogPost);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");

        }
    }
}