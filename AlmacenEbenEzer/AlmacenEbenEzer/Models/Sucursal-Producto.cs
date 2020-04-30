using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlmacenEbenEzer.Models
{
    public class Sucursal_Producto
    {
        [Display(Name = "ID Sucursal")]
        public int IDSucursal { get; set; }

        [Display(Name = "ID Producto")]
        public int IDProducto { get; set; }

        [Display(Name = "Cantidad en inventario")]
        public int Stock { get; set; }
    }
}