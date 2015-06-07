using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BillDetailController : Controller
    {
        private BillDetailContext db = new BillDetailContext();

        // GET: /BillDetail/
        public ActionResult Index()
        {
            return View(db.BillDetails.ToList());
        }

        // GET: /BillDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillDetail billdetail = db.BillDetails.Find(id);
            if (billdetail == null)
            {
                return HttpNotFound();
            }
            return View(billdetail);
        }

        // GET: /BillDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BillDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,MaHD,MaSach,SoLuong,DonGia")] BillDetail billdetail)
        {
            if (ModelState.IsValid)
            {
                db.BillDetails.Add(billdetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billdetail);
        }

        // GET: /BillDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillDetail billdetail = db.BillDetails.Find(id);
            if (billdetail == null)
            {
                return HttpNotFound();
            }
            return View(billdetail);
        }

        // POST: /BillDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,MaHD,MaSach,SoLuong,DonGia")] BillDetail billdetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billdetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billdetail);
        }

        // GET: /BillDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillDetail billdetail = db.BillDetails.Find(id);
            if (billdetail == null)
            {
                return HttpNotFound();
            }
            return View(billdetail);
        }

        // POST: /BillDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillDetail billdetail = db.BillDetails.Find(id);
            db.BillDetails.Remove(billdetail);
            db.SaveChanges();
            return RedirectToAction("Index");
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
