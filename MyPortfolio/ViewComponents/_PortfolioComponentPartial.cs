using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext portfoliContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfoliContext.Portfolios.ToList();
            return View(values);
        }
    }
}

