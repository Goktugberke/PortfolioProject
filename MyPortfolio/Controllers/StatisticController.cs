using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1= context.Skills.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Messages.Count();
            ViewBag.v4 = context.Messages.Where(x=>x.IsRead == false).Count();
            ViewBag.v5 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v6 = context.Experineces.Count();
            ViewBag.v7 = context.Portfolios.Where(x=> x.SubTitle == "Web Development").Count();
            ViewBag.v8 = context.Portfolios.Where(x => x.SubTitle == "Java").Count();
            ViewBag.v9 = context.Portfolios.Where(x => x.SubTitle == "Mobile").Count();
            ViewBag.v12 = context.Portfolios.Where(x => x.SubTitle == "Full Stack").Count();
            ViewBag.v10 = context.SocialMedias.Count();
            ViewBag.v11 = context.Testimonials.Count();
            return View();
        }
    }
}
