using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRUEBAPULSE.Models;
using System.Data;
using System.Data.Entity;

namespace PRUEBAPULSE.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Index()
        {
            using (Data context = new Data()) {
                return View(context.Eventos.ToList());
            }

                
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            using (Data context = new Data()) {
                
                return View(context.Eventos.Where(x => x.Id == id));
            }
            
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evento/Create
        [HttpPost]
        public ActionResult Create(Evento eventos)
        {
            using (Data context = new Data())
            {
                context.Eventos.Add(eventos);
                context.SaveChanges();

            }
            return RedirectToAction("Index");

            //try
            //{
                

            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            using (Data context = new Data())
            {

                return View(context.Eventos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Evento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Evento eventos)
        {
            try
            {
                using (Data context = new Data())
                {
                    context.Entry(eventos).State = EntityState.Modified;

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            using (Data context = new Data())
            {

                return View(context.Eventos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Evento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (Data context = new Data()) {
                    Evento evento = context.Eventos.Where(x => x.Id == id).FirstOrDefault();
                    context.Eventos.Remove(evento);
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
