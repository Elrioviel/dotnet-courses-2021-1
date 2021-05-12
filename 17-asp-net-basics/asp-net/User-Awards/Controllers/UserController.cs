using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Awards.Data;
using User_Awards.Models;

namespace User_Awards.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objList = _db.Users;
            return View(objList);
        }
        //GET-CreateUser
        public IActionResult CreateUser()
        {
            return View();
        }
        //POST-CreateUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
        //GET-Delete
        public IActionResult Delete(int? UserID)
        {
            if (UserID == null || UserID == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(UserID);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? UserID)
        {
            var obj = _db.Users.Find(UserID);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Users.Remove(obj);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
        //GET-Update
        public IActionResult Update(int? UserID)
        {
            if (UserID == null || UserID == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(UserID);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(User obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
