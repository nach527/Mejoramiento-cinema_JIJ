﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp_JIJ.Models
{
     public class ResumenCompra
    {
        public Pelicula pelicula { get; set; }
        public Funcion funcion { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }

    }
}
