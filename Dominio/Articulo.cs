using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    { 
        //Esta clase tiene la finalidad de definir la estructura de los objetos artículo

        //Propiedades, estas son utilizada para obtener y almacenar datos que proviene de la DB
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }

        //Creo propiedades del tipo marca y categoria que me permiten almacenar un objeto del mismo tipo
        //con la propiedad Id y Descripcion de cada una.
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

    }
}
