using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        //Propiedades para almacenar y obtener los valore que proviene de la DB
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        //Sobrecarta del Método
        public override string ToString()
        {
            return DescripcionCategoria;
        }
    }
}
