using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioEstados
    {
        DaoEstados daoEstados = new DaoEstados(); 

        public NegocioEstados()
        {
            
        }

        public DataTable getTablaEstados()
        {
            DataTable table = daoEstados.getTablaEstados(); 
            return table; 
        }
    }
}