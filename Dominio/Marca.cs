﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set;}

        public override string ToString()
        {
            return DescripcionMarca;
        }
    }
}
