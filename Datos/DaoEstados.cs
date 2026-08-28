using System;
using System.Data;
using Microsoft.AspNetCore.Http.Connections;

namespace Datos
{
    public class DaoEstados
    {
        AccesoDatos datos = new AccesoDatos(); 

        public DaoEstados()
        {
            
        }

        public DataTable getTablaEstados()
        {
            DataTable table = datos.ObtenerTabla("Estados", "SELECT IdEstado_E, Codigo_E, Estado_E FROM Estados"); 
            return table; 
        }
    }
}