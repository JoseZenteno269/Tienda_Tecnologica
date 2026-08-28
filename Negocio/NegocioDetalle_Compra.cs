using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioDetalle_Compras
    {
        DaoDetalle_Compra daoDetalle_Compra = new DaoDetalle_Compra(); 

        public NegocioDetalle_Compras()
        {
            
        }

        public DataTable getTablaDetalle()
        {
            DataTable table = daoDetalle_Compra.getTablaDetalle(); 
            return table; 
        }
    }
}