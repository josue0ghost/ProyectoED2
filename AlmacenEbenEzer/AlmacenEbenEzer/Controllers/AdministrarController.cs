using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlmacenEbenEzer.Models;

namespace AlmacenEbenEzer.Controllers
{
    public class AdministrarController : Controller
    {
        // GET: Administrar
        public ActionResult Index()
        {
            return View(Data.Instance.sucursales_productos);
        }

        // GET: Administrar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrar/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "IDSucursal,IDProducto,Stock")] Sucursal_Producto relacion)
        {
            if (ModelState.IsValid)
            {
                Data.Instance.sucursales_productos.Add(relacion);
                //Data.Instance.sucursalesTree.Add(sucursal);
                return RedirectToAction("Index");
            }

            return View(relacion);
        }

        // GET: Administrar/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Administrar/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "IDSucursal,IDProducto,Stock")] Sucursal_Producto relacion)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(movie).State = EntityState.Modified;
                //db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(relacion);
        }
       
        public ActionResult Transfer(int? id) {
            return View();
        }


        [HttpPost, ActionName("Transfer")]
        public ActionResult Transfer(int id, int id2, int idproducto, int qty) {
            return RedirectToAction("Index");
        }


        // GET: Administrar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrar/Delete/5
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
