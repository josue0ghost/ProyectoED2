using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlmacenEbenEzer.Models;

namespace AlmacenEbenEzer
{
    public class Data
    {
		private static Data instance = null;
		public static Data Instance
		{
			get
			{
				if (instance == null) instance = new Data();
				return instance;
			}
		}

		public List<Sucursal> sucursales = new List<Sucursal>();
	}
}