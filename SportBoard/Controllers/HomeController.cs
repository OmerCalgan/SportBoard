using SportBoard.Models;
using System.Linq;
using System.Web.Mvc;

namespace SportBoard.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var latestNews = db.News.OrderByDescending(n => n.PublishDate).Take(5).ToList();
            return View(latestNews);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
