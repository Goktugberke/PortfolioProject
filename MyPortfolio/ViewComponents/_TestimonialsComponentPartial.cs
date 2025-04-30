using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        MyPortfolioContext portfoliContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfoliContext.Testimonials.ToList();
            return View(values);
        }
    }
}

