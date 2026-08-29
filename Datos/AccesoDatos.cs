using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Datos
{
    public class AccesoDatos
    {
        // private readonly IConfiguration? configuration;
        private readonly string ruta = @"Server=R7ASUSROG\SQLEXPRESS;Database=CarritoComprasDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public AccesoDatos()
        {
            // ruta = configuration?.GetConnectionString("CarritoComprasDB") ?? 
            // throw new ArgumentNullException( nameof(configuration), "No se encontró la cadena de conexión.");
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection connection; 
            try
            {
                connection = new SqlConnection(ruta); 
                connection.Open(); 
                return connection; 
            }
            catch(SqlException e)
            {
                throw new Exception("No se pudo conectar a la base de datos", e);  
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consulta, SqlConnection connection)
        {
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(consulta, connection);
                return adapter; 
            }
            catch(SqlException e)
            {
                throw new Exception("No se pudo obtener el adaptador", e); 
            }
        }

        public int? ExecuteScalarInt(String consulta)
        {
            SqlConnection connection;
            try
            {
                connection = ObtenerConexion(); 
                SqlCommand command = new SqlCommand(consulta, connection); 
                object result = command.ExecuteScalar(); 
                return result != null ? Convert.ToInt32(result) : null; 
            }
            catch(SqlException e)
            {
                throw new Exception("No se obtuvo lo indicado", e); 
            }
        }

        public int? ExecuteScalarInt(SqlCommand command,String consulta)
        {
            SqlConnection connection;
            try
            {
                connection = ObtenerConexion(); 
                command.Connection = connection; 
                command.CommandText = consulta;  
                object result = command.ExecuteScalar(); 
                return result != null ? Convert.ToInt32(result) : null; 
            }
            catch(SqlException e)
            {
                throw new Exception("No se obtuvo lo indicado", e); 
            }
        }

        public String ExecuteScalarString(SqlCommand command,String consulta)
        {
            SqlConnection connection;
            try
            {
                connection = ObtenerConexion(); 
                command.Connection = connection; 
                command.CommandText = consulta;  
                object result = command.ExecuteScalar(); 
                return result != null ? result.ToString() : null;   
            }
            catch(SqlException e)
            {
                throw new Exception("No se obtuvo el valor indicado", e); 
            }
        }

        public DataTable ObtenerTabla(String nametable, String consulta)
        {
            SqlConnection connection;
            try
            {
                DataSet set = new DataSet();
                connection = ObtenerConexion(); 
                SqlDataAdapter adapter = ObtenerAdaptador(consulta, connection);
                adapter.Fill(set, nametable);
                connection.Close();
                return set.Tables[nametable];
            }
            catch(SqlException e)
            {
                throw new Exception("No se obtuvo la tabla", e); 
            }
        }

        public Boolean Existe(SqlCommand command, String consulta)
        {
            SqlConnection connection;
            try
            {
                connection = ObtenerConexion(); 
                command.Connection = connection;
                command.CommandText = consulta; 
                SqlDataReader leer = command.ExecuteReader();
                bool existe = leer.Read();
                connection.Close(); 
                return existe;
            }
            catch(SqlException e)
            {
                throw new Exception("No se encontro coincidencia", e); 
            }
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand command, String procedimiento)
        {
            SqlConnection connection;
            try
            {
                connection = ObtenerConexion(); 
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedimiento;
                int filasafectadas = command.ExecuteNonQuery();
                connection.Close(); 
                return filasafectadas;
            }
            catch(SqlException e)
            {
                throw new Exception("No se encontro el procedimiento", e); 
            }
        }
    }
}