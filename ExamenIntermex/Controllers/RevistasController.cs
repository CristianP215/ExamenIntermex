using ExamenIntermex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenIntermex.Controllers
{
    public class RevistasController : Controller
    {
        // GET: Revistas
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Revista.ToList());
            }

            
        }

        // GET: Revistas/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Revista.Where(x=>x.id_revista == id).FirstOrDefault());
            }

            
        }

        // GET: Revistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Revistas/Create
        [HttpPost]
        public ActionResult Create(Revista revista)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.Revista.Add(revista);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Revistas/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Revista.Where(x => x.id_revista == id).FirstOrDefault());
            }
        }

        // POST: Revistas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Revista revista)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.Entry(revista).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Revistas/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Revista.Where(x => x.id_revista == id).FirstOrDefault());
            }
        }

        // POST: Revistas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels context = new DbModels())
                {
                    Revista revista = context.Revista.Where(x => x.id_revista == id).FirstOrDefault();
                    context.Revista.Remove(revista);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
