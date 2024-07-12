using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lvh_Aspnet_Lesson12.Models;

namespace Lvh_Aspnet_Lesson12.Controllers
{
    public class Lvh_TACGIAController : Controller
    {
        private LeVinhHuy_2210900106Entities db = new LeVinhHuy_2210900106Entities();

        // GET: Lvh_TACGIA
        public ActionResult LvhIndex()
        {
            return View(db.Lvh_TACGIA.ToList());
        }

        // GET: Lvh_TACGIA/Details/5
        public ActionResult LvhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_TACGIA lvh_TACGIA = db.Lvh_TACGIA.Find(id);
            if (lvh_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(lvh_TACGIA);
        }

        // GET: Lvh_TACGIA/Create
        public ActionResult LvhCreate()
        {
            return View();
        }

        // POST: Lvh_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvhCreate([Bind(Include = "Lvh_MaTG,Lvh_TenTG")] Lvh_TACGIA lvh_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Lvh_TACGIA.Add(lvh_TACGIA);
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }

            return View(lvh_TACGIA);
        }

        // GET: Lvh_TACGIA/Edit/5
        public ActionResult LvhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_TACGIA lvh_TACGIA = db.Lvh_TACGIA.Find(id);
            if (lvh_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(lvh_TACGIA);
        }

        // POST: Lvh_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvhEdit([Bind(Include = "Lvh_MaTG,Lvh_TenTG")] Lvh_TACGIA lvh_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lvh_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }
            return View(lvh_TACGIA);
        }

        // GET: Lvh_TACGIA/Delete/5
        public ActionResult LvhDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_TACGIA lvh_TACGIA = db.Lvh_TACGIA.Find(id);
            if (lvh_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(lvh_TACGIA);
        }

        // POST: Lvh_TACGIA/Delete/5
        [HttpPost, ActionName("LvhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Lvh_TACGIA lvh_TACGIA = db.Lvh_TACGIA.Find(id);
            db.Lvh_TACGIA.Remove(lvh_TACGIA);
            db.SaveChanges();
            return RedirectToAction("LvhIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
