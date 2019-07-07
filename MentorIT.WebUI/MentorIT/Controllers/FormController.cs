using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentorIT.Models;

namespace MentorIT.Controllers
{
    public class FormController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Form
        public ActionResult Index()
        {

            return View(db.Forms);
        }

        // GET: Form/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Form form = db.Forms.Find(id);
            return View(form);

        }

        // GET: Form/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Form/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Forms.Add(new Form
                {
                    Age = Int32.Parse(collection[nameof(Form.Age)]),
                    Name = collection["Name"]
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Form/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Form form = db.Forms.Find(id);
            return View(form);
        }

        // POST: Form/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (id == null)
                {
                    return HttpNotFound();
                }

                Form form = db.Forms.Find(id);
                form.Age = Int32.Parse(collection["Age"]);
                form.Name = collection["Name"];
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Form/Delete/5
        public ActionResult Delete(int id)
        {
            Form f = db.Forms.Find(id);
            if (f != null)
            {
                db.Forms.Remove(f);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Form/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
