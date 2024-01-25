﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discos
{
    public class Disco
    {
        public string Name { get; set; }
        public DateTime Fecha { get; set; }
        public string UrlImagen { get; set; }
        public int Tracks { get; set; }
        public Estilo Genre { get; set; }
        public Estilo Formato { get; set; }
    }
}
