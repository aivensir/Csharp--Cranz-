using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cranz1.Data;
using Cranz1.Models;

namespace Cranz1.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository UserRepository;

        public HomeController()
        {
            UserRepository = new EfUserRepository();
        }
        public ActionResult Index()
        {
            IQueryable<User> Users = UserRepository.Users;
            if (!Users.Any()) return View("Index", null);
            return View(Users);
        }

        public ActionResult SignUp()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            UserRepository.CreateUser(user);
            return RedirectToAction("Index");
        }
    }
}