﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public TipoDocumentoCompra oTipoDocumentoCompra { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }

    }
}
