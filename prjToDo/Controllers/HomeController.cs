using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjToDo.Models;

namespace prjToDo.Controllers
{
    public class HomeController : Controller
    {
        dbToDoEntities db = new dbToDoEntities();
        // GET: Home
        public ActionResult Index()
        {
            var todos = db.tToDo.OrderByDescending(m => m.fDate).ToList();
            return View(todos);
        }
        public ActionResult Create()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Create(string fTitle,string fImgae,DateTime fDate)
        {
            tToDo todo = new tToDo();
            todo.fTitle = fTitle;
            todo.fimage = fImgae;
            todo.fDate = fDate;
            db.tToDo.Add(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            var todo = db.tToDo.Where(m => m.fId == Id).FirstOrDefault();
            db.tToDo.Remove(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            var todo = db.tToDo.Where(m => m.fId == Id).FirstOrDefault();
           
            return View(todo);
        }
        [HttpPost]
        public ActionResult Edit(int fId,string fTitle, string fImgae, DateTime fDate)
        {
            var todo = db.tToDo.Where(m => m.fId == fId).FirstOrDefault();
            todo.fTitle = fTitle;
            todo.fimage = fImgae;
            todo.fDate = fDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}