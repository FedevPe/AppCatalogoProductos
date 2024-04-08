using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    //Esta clase me permite conectarme a la base de datos realizar consultas u operaciones contra ella.
    public class AccesoDatos
    {   
        //CAMPOS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //PROPIEDAD
        public SqlDataReader Lector { get { return lector; } set { lector = value; } }

        //CONSTRUCTOR DE LA CLASE
        public AccesoDatos()
        {
            conexion = new SqlConnection("Server = .\\SQLEXPRESS; Database = CATALOGO_DB; integrated security = true");
            comando = new SqlCommand();
        }


        //MÉTODOS

        //Método para configurar la consulta u operacion contra la DB
        public void ConfigurarConsulta(string consulta)
        {
            //Determino el tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Asigno al comando la consulta u operación que debe hacer en la DB
            comando.CommandText = consulta;
        }
        
        //Método que abre la conexcion con la DB, obtener datos de ella y asignarlos en el campo lector
        //utilizando su propiedad
        public void EjecutarLectura()
        {
            //Conecta con la DB, en el contructor se especifica cual es.
            comando.Connection = conexion;

            try
            {
                //Abre la conexión
                conexion.Open();
                //Guarda los datos en el campo lector
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //En caso de que se quiera realizar una consutal del tipo NonQuery (Inser, Delete, Update),
        //se utiliza este método.
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
        //Método que me permite configurar los parámetros de las operaciones que se realizan contra la DB.
        public void ConfigurarParametros(string parametro, object variable)
        {
            comando.Parameters.AddWithValue(parametro, variable);
        }

        //Método que cierra la conexión
        public void CerrarConexion()
        {
            lector?.Read(); //forma de comprobar que el lector no este vacio.
            conexion.Close();
        }

    }
}
