﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using AlmacenEbenEzer.Models;
using AlmacenEbenEzer.Tree;

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

		//Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + @"\Sucursales.txt"
		public Tree<Sucursal> sucursalesTree = new Tree<Sucursal>(5, @"C:\Users\llaaj\Desktop\Sucursales.txt", new CreateSucursal());


		public SDES cipherMethods = new SDES();
		//listas para pruebas temporales 
		public List<Sucursal> sucursales = new List<Sucursal>();
		public List<Producto> productos = new List<Producto>();
		public List<Sucursal_Producto> sucursales_productos = new List<Sucursal_Producto>();
	}
}