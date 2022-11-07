﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarcoaFinalV3.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}