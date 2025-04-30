using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        MyPortfolioContext portfoliContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfoliContext.SocialMedias.ToList(); 
            return View(values);
        }
    }   
}
