﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Detalle
    {
        public int FacturaId { get; set; }

        public int ProductoId { get; set; }

        public decimal Precio { get; set; }

        public decimal Cantidad { get; set; }
    }
}