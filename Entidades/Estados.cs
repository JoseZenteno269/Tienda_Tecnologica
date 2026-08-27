using System; 

namespace Entidades
{
    public class Estados
    {
        private int idestado; 
        private String codigo; 
        private String estado; 

        public Estados()
        {
            idestado = 0; 
            codigo = "no definido"; 
            estado = "no definido"; 
        }

        public Estados(int idestado, String codigo, String estado)
        {
            this.idestado = idestado; 
            this.codigo = codigo; 
            this.estado = estado; 
        }

        public int IdEstado
        {
            get
            {
                return idestado; 
            }
            set
            {
                idestado = value; 
            }
        }

        public String Codigo
        {
            get
            {
                return codigo; 
            }
            set
            {
                codigo = value; 
            }
        }

        public String Estado
        {
            get
            {
                return estado; 
            }
            set
            {
                estado = value; 
            }
        }
    }
}