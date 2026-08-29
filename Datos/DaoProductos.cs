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
            DataTable tabla = datos.ObtenerTabla("Productos", "SELECT Codigo_P, Nombre_P, Tipo_T, IdTipo_P, Descripcion_P, Precio_P, Stock_P, Imagen_P FROM Productos p INNER JOIN Tipo t ON p.IdTipo_P = t.IdTipo_T"); 
            return tabla; 
        }
    }
}