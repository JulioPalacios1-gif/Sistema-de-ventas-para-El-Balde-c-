﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Venta oVenta { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
