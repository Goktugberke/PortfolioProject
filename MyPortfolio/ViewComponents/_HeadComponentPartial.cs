using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        MyPortfolioContext portfoliContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfoliContext.Abouts.ToList();
            return View(values);
        }
    }
}
