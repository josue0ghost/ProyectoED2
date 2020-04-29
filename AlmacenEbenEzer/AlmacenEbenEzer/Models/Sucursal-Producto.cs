using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenEbenEzer.Models
{
    public class Sucursal_Producto
    {
        public int IDSucursal { get; set; }
        public int IDProducto { get; set; }
        public int Stock { get; set; }
    }
}