using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioCompras
    {
        DaoCompras daoCompras = new DaoCompras(); 

        public NegocioCompras()
        {
            
        }

        public DataTable getTablaCompras()
        {
            DataTable table = daoCompras.getTablaCompras(); 
            return table; 
        }
    }
}