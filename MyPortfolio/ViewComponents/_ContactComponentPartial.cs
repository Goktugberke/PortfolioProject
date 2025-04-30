using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext portfoliContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactTitle = portfoliContext.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactDescription = portfoliContext.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactPhone1 = portfoliContext.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactPhone2 = portfoliContext.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.contactEmail1 = portfoliContext.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactEmail2 = portfoliContext.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactAddress = portfoliContext.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
