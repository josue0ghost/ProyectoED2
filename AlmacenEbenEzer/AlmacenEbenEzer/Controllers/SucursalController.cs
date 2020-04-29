using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlmacenEbenEzer.Models;

namespace AlmacenEbenEzer.Controllers
{
    public class SucursalController : Controller
    {

        //<input type = "button" value="Sucursales" onclick="location.href='@Url.Action("Index", "Sucursal")'" class="btn btn-default" />
        // GET: Sucursal
        public ActionResult Index()
        {
            return View(Data.Instance.sucursales);
        }

        // GET: Sucursal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sucursal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursal/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Nombre,Direccion")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                Data.Instance.sucursales.Add(sucursal);
                //Data.Instance.sucursalesTree.Add(sucursal);
                return RedirectToAction("Index");
            }

            return View(sucursal);
        }

        // GET: Sucursal/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Sucursal/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Direccion")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(movie).State = EntityState.Modified;
                //db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(sucursal);
        }

        // GET: Sucursal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sucursal/Delete/5
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
