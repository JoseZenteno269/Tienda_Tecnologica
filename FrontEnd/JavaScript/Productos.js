const host = "https://localhost:7040/api/Productos"

import { crearCelda } from "./funciones.js"

const mensaje = document.getElementById("lbl_mensaje"); 

mensaje.textContent = ""; 

async function cargarProductos() {                                                          
    const respuesta_prod = await fetch(`${host}/${"productos"}`); 

    if(!respuesta_prod.ok){
        mensaje.textContent = "No se pudo conectar a la base de datos"; 
    }

    const productos = await respuesta_prod.json(); 
    const tablacuerpo = document.getElementById("cuerpo_tabla"); 

    tablacuerpo.innerHTML = ""; 

    productos.forEach(prod => {
        const tr = document.createElement("tr"); 

        let codigo = crearCelda(prod.codigo); 
        let nombre = crearCelda(prod.nombre); 
        let descripcion = crearCelda(prod.descripcion); 
        let precio = crearCelda(prod.precio);
        let stock = crearCelda(prod.stock); 
        let imagen = crearCelda(prod.imagen); 

        tr.appendChild(codigo); 
        tr.appendChild(nombre); 
        tr.appendChild(descripcion); 
        tr.appendChild(precio); 
        tr.appendChild(stock); 
        tr.appendChild(imagen); 

        tablacuerpo.appendChild(tr); 
    });
}

document.addEventListener("DOMContentLoaded", async () => {
    await cargarProductos(); 
});