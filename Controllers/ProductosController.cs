using System;
using System.Data;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly NegocioProductos negocioProductos = new NegocioProductos(); 

        [HttpGet("productos")]
        public IActionResult ObtenerProductos()
        {
            DataTable table = negocioProductos.getTablaProductos();

            List<ProductosResponse> lista = new();
            
            foreach(DataRow fila in table.Rows)
            {
                lista.Add(new ProductosResponse
                {
                    codigo = fila["Codigo_P"].ToString(),
                    nombre = fila["Nombre_P"].ToString(),
                    descripcion = fila["Descripcion_P"].ToString(),
                    precio = Convert.ToDouble(fila["Precio_P"]),
                    stock = Convert.ToInt32(fila["Stock_P"]),
                    imagen = fila["Imagen_P"].ToString(),
                    tipo = fila["Tipo_T"].ToString()
                });
            }
            
            return Ok(lista); 
        }
    }
}