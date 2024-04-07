using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {        
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return lector; } set { lector = value; } }

        public AccesoDatos()
        {
            conexion = new SqlConnection("Server = .\\SQLEXPRESS; Database = CATALOGO_DB; integrated security = true");
            comando = new SqlCommand();
        }

        public void ConfigurarConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConfigurarParametros(string parametro, object variable)
        {
            comando.Parameters.AddWithValue(parametro, variable);
        }
        public void CerrarConexion()
        {
            lector?.Read();
            conexion.Close();
        }

    }
}
