using Microsoft.AspNet.Identity;
using SportBoard.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SportBoard.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var news = db.News.OrderByDescending(n => n.PublishDate).ToList();
            return View(news);
        }

        public ActionResult Details(int id)
        {
            var news = db.News.Include(n => n.Comments).SingleOrDefault(n => n.NewsId == id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddComment(int newsId, string content)
        {
            var news = db.News.Find(newsId);
            if (news == null)
            {
                return HttpNotFound();
            }

            var comment = new Comment
            {
                Content = content,
                CommentDate = DateTime.Now,
                UserId = User.Identity.GetUserId(),
                NewsId = newsId
            };

            db.Comments.Add(comment);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = newsId });
        }
    }
}
