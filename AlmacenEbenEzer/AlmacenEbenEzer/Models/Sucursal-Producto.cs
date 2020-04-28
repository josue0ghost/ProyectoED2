using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenEbenEzer.Models
{
    public class Sucursal_Producto
    {
        int IDSucursal { get; set; }
        int IDProducto { get; set; }
        int stock { get; set; }
    }
}