using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AlmacenEbenEzer.Models;

namespace AlmacenEbenEzer.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View(Data.Instance.productos);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                Data.Instance.productos.Add(producto);
                //Data.Instance.sucursalesTree.Add(sucursal);
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        [HttpPost, ActionName("addFile")]
        public ActionResult AddFile(HttpPostedFileBase file) {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.InputStream))
            {
                while (reader.Peek() >= 0)
                    Data.Instance.productos.Add(readProducto(reader.ReadLine()));
            }

            return RedirectToAction("Index");
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int? id)
        {
            //Producto producto = null;
            ////muestra de como funcionaría volver a cargar los datos en el form
            //for (int i = 0; i < Data.Instance.productos.Count; i++)
            //{
            //    if (Data.Instance.productos[i].ID == id)
            //    {
            //        producto = Data.Instance.productos[i];
            //    }
            //}
            //// return View(producto);
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(movie).State = EntityState.Modified;
                //db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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


        static Producto readProducto(string line)
        {
            string[] items = line.Split(',');
            Producto response = new Producto();
            response.ID = int.Parse(items[0]);
            response.Nombre = items[1];
            response.Precio = decimal.Parse(items[2]);

            return response;
        }
    }
}
