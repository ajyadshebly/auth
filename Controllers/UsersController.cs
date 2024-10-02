using auth.Context;
using auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace auth.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult IndexA()
        {
            var user = context.Users.ToList();
            return View(user);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult InactiveUsers()
        {
            var inactiveUsers = context.Users.Where(u => u.IsActive == false).ToList();
            return View(inactiveUsers);
        }
        public IActionResult ActivateUser(int UserId)
        {
            var user = context.Users.Find(UserId);
            if (user != null)
            {
                user.IsActive = true;
                context.SaveChanges();
            }
            return RedirectToAction("InactiveUsers");
        }

    }
}
