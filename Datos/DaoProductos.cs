using System.ComponentModel.DataAnnotations.Schema;
using System.Data; 


namespace Datos
{
    public class DaoProductos
    {
        AccesoDatos datos = new AccesoDatos();

        public DaoProductos()
        {
            
        }

        public DataTable getTablaProductos()
        {
            DataTable tabla = datos.ObtenerTabla("Productos", "SELECT IdProducto_P, Codigo_P, Nombre_P, Descripcion_P, Precio_P, Stock_P, Imagen_P, Activo_P FROM Productos"); 
            return tabla; 
        }
    }
}