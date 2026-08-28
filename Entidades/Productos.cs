using System;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Productos
    {
        private String idproducto; 
        private String codigo; 
        private String nombre; 
        private String descripcion; 
        private double precio; 
        private int stock; 
        private String imagen; 
        private Boolean activo; 

        public Productos()
        {
            idproducto = "no definido"; 
            codigo = "no definido"; 
            nombre = "no definido"; 
            descripcion = "no definido"; 
            precio = 0;
            stock = 0; 
            imagen = "no definido"; 
            activo = true; 
        }

        public Productos(String idproducto, String codigo, String nombre, String descripcion,
         float precio, int stock, String imagen, Boolean activo)
        {
            this.idproducto = idproducto; 
            this.codigo = codigo; 
            this.nombre = nombre; 
            this.descripcion = descripcion; 
            this.precio = precio; 
            this.stock = stock; 
            this.imagen = imagen; 
            this.activo = activo; 
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

        public String Nombre
        {
            get
            {
                return nombre; 
            }
            set
            {
                nombre = value; 
            }
        }
        public String Descripcion
        {
            get
            {
                return descripcion; 
            }
            set
            {
                descripcion = value; 
            }
        }

        public double Precio
        {
            get
            {
                return precio; 
            }
            set{
                precio = value; 
            }
        }

        public int Stock
        {
            get
            {
                return stock; 
            }
            set
            {
                stock = value; 
            }
        }

        public String Imagen
        {
            get
            {
                return imagen; 
            }
            set
            {
                imagen = value; 
            }
        }

        public Boolean Activo
        {
            get
            {
                return activo; 
            }
            set
            {
                activo = value; 
            }
        }
    }
}