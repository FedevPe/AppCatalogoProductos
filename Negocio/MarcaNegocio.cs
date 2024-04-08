using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    //En esta clase defino el método para obtener las categorías cargadas en la DB.
    public class MarcaNegocio
    {
        List<Marca> marcas = new List<Marca>();

        public List<Marca> LeerDatosMarca()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("Select Id, Descripcion Marca from MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca()
                    {
                        IdMarca = (int)datos.Lector["Id"],
                        DescripcionMarca = (string)datos.Lector["Marca"]
                    };
                    marcas.Add(aux);
                }

                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
