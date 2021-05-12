using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Awards.Data;
using User_Awards.Models;

namespace User_Awards.Controllers
{
    public class AwardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AwardController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Award> objList = _db.Awards;
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
        public IActionResult CreateUser(Award obj)
        {
            if (ModelState.IsValid)
            {
                _db.Awards.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET-Delete
        public IActionResult Delete(int? AwardID)
        {
            if (AwardID==null || AwardID==0)
            {
                return NotFound();
            }
            var obj = _db.Awards.Find(AwardID);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? AwardID)
        {
            var obj = _db.Awards.Find(AwardID);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                 _db.Awards.Remove(obj);
                _db.SaveChanges();
            }
            
                return RedirectToAction("Index");
            
        }
        //GET-Update
        public IActionResult Update(int? AwardID)
        {
            if (AwardID == null || AwardID == 0)
            {
                return NotFound();
            }
            var obj = _db.Awards.Find(AwardID);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Award obj)
        {
            if (ModelState.IsValid)
            {
                _db.Awards.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
