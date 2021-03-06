﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shoestore.Models;

namespace Shoestore.Controllers
{
    public class Table_4Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_4
        public ActionResult Index()
        {
            return View(db.Table_4.ToList());
        }

        // GET: Table_4/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_4 table_4 = db.Table_4.Find(id);
            if (table_4 == null)
            {
                return HttpNotFound();
            }
            return View(table_4);
        }

        // GET: Table_4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_4/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "footsize,models,price,rating")] Table_4 table_4)
        {
            if (ModelState.IsValid)
            {
                db.Table_4.Add(table_4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_4);
        }

        // GET: Table_4/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_4 table_4 = db.Table_4.Find(id);
            if (table_4 == null)
            {
                return HttpNotFound();
            }
            return View(table_4);
        }

        // POST: Table_4/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "footsize,models,price,rating")] Table_4 table_4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_4);
        }

        // GET: Table_4/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_4 table_4 = db.Table_4.Find(id);
            if (table_4 == null)
            {
                return HttpNotFound();
            }
            return View(table_4);
        }

        // POST: Table_4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_4 table_4 = db.Table_4.Find(id);
            db.Table_4.Remove(table_4);
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
