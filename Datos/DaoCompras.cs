using System;
using System.Data;

namespace Datos
{
    public class DaoCompras
    {
        AccesoDatos datos = new AccesoDatos(); 

        public DaoCompras()
        {
            
        }

        public DataTable getTablaCompras()
        {
            DataTable table = datos.ObtenerTabla("Compras", "SELECT IdCompra_C, Fecha_C, IdEstado_C, Total_C FROM Compras");
            return table;  
        }
    }
}