﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StarCinema.Models;

namespace StarCinema.Controllers
{
    public class BiletsController : Controller
    {
        private MoviesContext db = new MoviesContext();

        // GET: Bilets
        public ActionResult Index()
        {
            return View(db.Bilets.ToList());
        }

        // GET: Bilets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bilet bilet = db.Bilets.Find(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // GET: Bilets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bilets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bilet,cena,e_mail,vreme_na_rezervacija,id_proekcija,id_film,broj_sala,broj_sediste,broj_red")] Bilet bilet)
        {
            if (ModelState.IsValid)
            {
                db.Bilets.Add(bilet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bilet);
        }

        // GET: Bilets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bilet bilet = db.Bilets.Find(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // POST: Bilets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bilet,cena,e_mail,vreme_na_rezervacija,id_proekcija,id_film,broj_sala,broj_sediste,broj_red")] Bilet bilet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bilet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bilet);
        }

        // GET: Bilets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bilet bilet = db.Bilets.Find(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // POST: Bilets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bilet bilet = db.Bilets.Find(id);
            db.Bilets.Remove(bilet);
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
