using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    //En esta clase defino el método para obtener las categorías cargadas en la DB.
    public class CategoriaNegocio
    {
        private List<Categoria> categorias = new List<Categoria>();

        public List<Categoria> LeerDatosCategoria()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("Select Id, Descripcion Categoria from CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria()
                    {
                        IdCategoria = (int)datos.Lector["Id"],
                        DescripcionCategoria = (string)datos.Lector["Categoria"]
                    };
                    categorias.Add(aux);
                }

                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
