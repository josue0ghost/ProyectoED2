using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlmacenEbenEzer.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
    }
}