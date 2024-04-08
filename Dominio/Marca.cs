using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        //Propiedades para almacenar y obtener los valore que proviene de la DB
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set;}

        //Sobrecarta del Método
        public override string ToString()
        {
            return DescripcionMarca;
        }
    }
}
