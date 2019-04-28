﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library2.Models;

namespace Library2.Controllers
{
    public class ReaderController : Controller
    {
        private LibraryContext db = new LibraryContext();



        // GET: Reader/CreateBook/5
        public ActionResult CreateBook(int? id)
        {        
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Reader reader = db.Readers.Find(id);
                if (reader == null)
                {
                    return HttpNotFound();
                }
                ViewBag.Books = db.Books.ToList();
                return View(reader);
            }

        [HttpPost]
        public ActionResult CreateBook(Reader reader, int[] selectedBooks)
        {
            Reader newReader = db.Readers.Find(reader.ReaderId);
            newReader.Name = reader.Name;


            newReader.Books.Clear();
            if (selectedBooks != null)
            {
                //получаем выбранные книги
                foreach (var b in db.Books.Where(co => selectedBooks.Contains(co.Id)))
                {
                    newReader.Books.Add(b);
                }
            }

            db.Entry(newReader).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details");
        }


        // GET: Reader
        public ActionResult Index()
        {
            return View(db.Readers.ToList());
        }


        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public ActionResult Buy(Reader reader, int[] selectedBooks)
        {
            Reader newReader = db.Readers.Find(reader.ReaderId);
            newReader.Name = reader.Name;


            newReader.Books.Clear();
            if (selectedBooks != null)
            {
                //получаем выбранные книги
                foreach (var c in db.Books.Where(co => selectedBooks.Contains(co.Id)))
                {
                    newReader.Books.Add(c);
                }
            }

            db.Entry(newReader).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details");
        }



        // GET: Reader/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.Readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            return View(reader);
        }

        // GET: Reader/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reader/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReaderId,Name")] Reader reader)
        {
            try
            {
                if (ModelState.IsValid)
            {
                db.Readers.Add(reader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(reader);
        }

        // GET: Reader/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.Readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            ViewBag.Books = db.Books.ToList();
            return View(reader);
        }

        // POST: Reader/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Reader reader, int[] selectedBooks)
        {
            Reader newReader = db.Readers.Find(reader.ReaderId);
            newReader.Name = reader.Name;
            

            newReader.Books.Clear();
            if (selectedBooks != null)
            {
                //получаем выбранные книги
                foreach (var c in db.Books.Where(co => selectedBooks.Contains(co.Id)))
                {
                    newReader.Books.Add(c);
                }
            }

            db.Entry(newReader).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Reader/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reader reader = db.Readers.Find(id);
            if (reader == null)
            {
                return HttpNotFound();
            }
            return View(reader);
        }

        // POST: Reader/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reader reader = db.Readers.Find(id);
            db.Readers.Remove(reader);
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
