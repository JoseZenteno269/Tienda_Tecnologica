using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioProductos
    {
        DaoProductos daoProductos = new DaoProductos(); 

        public NegocioProductos()
        {
            
        }

        public DataTable getTablaProductos()
        {   
            return daoProductos.getTablaProductos(); 
        }
    }
}