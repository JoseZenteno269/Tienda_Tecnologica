using System;
using System.Xml;

namespace Entidades
{
    public class Compras
    {
        private int idcompra; 
        private String idproducto; 
        private int cantidad; 
        private float precio; 

        public Compras()
        {
            idcompra = 0; 
            idproducto = "no definido"; 
            cantidad = 0; 
            precio = 0; 
        }

        public Compras(int idcompra, String idproducto, int cantidad, float precio)
        {
            this.idcompra = idcompra; 
            this.idproducto = idproducto; 
            this.cantidad = cantidad; 
            this.precio = precio; 
        }

        public int IdCompra
        {
            get
            {
                return idcompra; 
            }
            set
            {
                idcompra = value; 
            }
        }

        public String IdProducto
        {
            get
            {
                return idproducto; 
            }
            set
            {
                idproducto = value; 
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad; 
            }
            set
            {
                cantidad = value; 
            }
        }

        public float Precio
        {
            get
            {
                return precio; 
            }
            set
            {
                precio = value; 
            }
        }
    }
}