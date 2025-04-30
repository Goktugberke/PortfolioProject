using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult AccountsList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(SocialMedia account)
        {
            context.SocialMedias.Add(account);
            context.SaveChanges();
            return RedirectToAction("AccountsList");
        }

        public IActionResult DeleteAccount(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AccountsList");
        }

        [HttpGet]
        public IActionResult UpdateAccount(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAccount(SocialMedia account)
        {
            context.SocialMedias.Update(account);
            context.SaveChanges();
            return RedirectToAction("AccountsList");
        }

    }
}

