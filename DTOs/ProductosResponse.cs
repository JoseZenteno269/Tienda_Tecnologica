using Microsoft.AspNetCore.Routing.Constraints;

namespace DTOs
{
    public class ProductosResponse
    {
        public String codigo {get; set;}
        public String nombre {get; set;}
        public String descripcion {get; set;}
        public double  precio {get; set;}
        public int stock {get; set;}
        public String imagen {get; set;}
        public String tipo {get; set;}
    }
}