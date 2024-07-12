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
    public class Lvh_SACHController : Controller
    {
        private LeVinhHuy_2210900106Entities db = new LeVinhHuy_2210900106Entities();

        // GET: Lvh_SACH
        public ActionResult LvhIndex()
        {
            var lvh_SACH = db.Lvh_SACH.Include(l => l.Lvh_TACGIA);
            return View(lvh_SACH.ToList());
        }

        // GET: Lvh_SACH/Details/5
        public ActionResult LvhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_SACH lvh_SACH = db.Lvh_SACH.Find(id);
            if (lvh_SACH == null)
            {
                return HttpNotFound();
            }
            return View(lvh_SACH);
        }

        // GET: Lvh_SACH/Create
        public ActionResult LvhCreate()
        {
            ViewBag.Lvh_MaTG = new SelectList(db.Lvh_TACGIA, "Lvh_MaTG", "Lvh_TenTG");
            return View();
        }

        // POST: Lvh_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvhCreate([Bind(Include = "Lvh_MaSach,Lvh_TenSach,Lvh_SoTrang,Lvh_NamXB,Lvh_MaTG,Lvh_TrangThai")] Lvh_SACH lvh_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Lvh_SACH.Add(lvh_SACH);
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }

            ViewBag.Lvh_MaTG = new SelectList(db.Lvh_TACGIA, "Lvh_MaTG", "Lvh_TenTG", lvh_SACH.Lvh_MaTG);
            return View(lvh_SACH);
        }

        // GET: Lvh_SACH/Edit/5
        public ActionResult LvhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_SACH lvh_SACH = db.Lvh_SACH.Find(id);
            if (lvh_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Lvh_MaTG = new SelectList(db.Lvh_TACGIA, "Lvh_MaTG", "Lvh_TenTG", lvh_SACH.Lvh_MaTG);
            return View(lvh_SACH);
        }

        // POST: Lvh_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvhEdit([Bind(Include = "Lvh_MaSach,Lvh_TenSach,Lvh_SoTrang,Lvh_NamXB,Lvh_MaTG,Lvh_TrangThai")] Lvh_SACH lvh_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lvh_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LvhIndex");
            }
            ViewBag.Lvh_MaTG = new SelectList(db.Lvh_TACGIA, "Lvh_MaTG", "Lvh_TenTG", lvh_SACH.Lvh_MaTG);
            return View(lvh_SACH);
        }

        // GET: Lvh_SACH/Delete/5
        public ActionResult LvhDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lvh_SACH lvh_SACH = db.Lvh_SACH.Find(id);
            if (lvh_SACH == null)
            {
                return HttpNotFound();
            }
            return View(lvh_SACH);
        }

        // POST: Lvh_SACH/Delete/5
        [HttpPost, ActionName("LvhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult LvhDeleteConfirmed(string id)
        {
            Lvh_SACH lvh_SACH = db.Lvh_SACH.Find(id);
            db.Lvh_SACH.Remove(lvh_SACH);
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
