using System;
using System.Data;

namespace Datos
{
    public class DaoDetalle_Compra
    {
        AccesoDatos datos = new AccesoDatos(); 

        public DaoDetalle_Compra()
        {
            
        }

        public DataTable getTablaDetalle()
        {
            DataTable table = datos.ObtenerTabla("Detalle_Compra", "SELECT IdCompra_DC, IdProducto_DC, Cantidad_DC, Precio_DC FROM Detalle_Compra"); 
            return table; 
        }
    }
}