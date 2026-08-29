const host = "https://localhost:7040/api/Productos"

import { crearCelda, crearCeldaImg, crearButton} from "./funciones.js"

const mensaje = document.getElementById("lbl_mensaje"); 
mensaje.textContent = ""; 

let carrito = []; 

async function cargarProductos() { 
    const respuesta_prod = await fetch(`${host}/${"productos"}`); 

    if(!respuesta_prod.ok){
        mensaje.textContent = "No se pudo conectar a la base de datos"; 
    }

    const productos = await respuesta_prod.json(); 
    const tablacuerpo = document.getElementById("cuerpo_tabla"); 

    // tablacuerpo.innerHTML = ""; 

    productos.forEach(prod => {
        const tr = document.createElement("tr"); 

        const codigo = crearCelda(prod.codigo); 
        const nombre = crearCelda(prod.nombre); 
        const descripcion = crearCelda(prod.descripcion); 
        const precio = crearCelda("$" + prod.precio);
        const stock = crearCelda(prod.stock); 
        const imagen = crearCeldaImg(prod.imagen); 
        const tipo = crearCelda(prod.tipo)
        const btn_agregar = crearButton(" + ", ""); 

        tr.appendChild(codigo); 
        tr.appendChild(nombre); 
        tr.appendChild(tipo); 
        tr.appendChild(descripcion); 
        tr.appendChild(precio); 
        tr.appendChild(stock); 
        tr.appendChild(imagen); 
        tr.appendChild(btn_agregar); 

        tablacuerpo.appendChild(tr); 

        btn_agregar.addEventListener("click", () => {
            // agregarAlCarrito(prod); 

            const tablaseleccionados = document.getElementById("tabla_seleccionados");

            const tr = document.createElement("tr");
            const btn_eliminar = crearButton("🗑️", ""); 

            tr.appendChild(crearCelda(prod.codigo));
            tr.appendChild(crearCelda(prod.nombre));
            tr.appendChild(crearCelda(prod.descripcion));
            tr.appendChild(crearCelda(prod.precio));
            tr.appendChild(btn_eliminar); 

            tablaseleccionados.appendChild(tr); 

            btn_eliminar.addEventListener("click", () => {
                tr.remove(); 
            }); 
        }); 
    });

}

// function agregarAlCarrito(prod) {
//     carrito.push(prod);
//     renderizarCarrito();
// }

// function renderizarCarrito() {
//     const tablaseleccionados = document.getElementById("tabla_seleccionados");
//     tablaseleccionados.innerHTML = "";
    
//     let tr; 
//     let btn_eliminar;
    
//     carrito.forEach(prod => {
//         tr = document.createElement("tr");
//         btn_eliminar = crearButton("🗑️", ""); 

//         tr.appendChild(crearCelda(prod.codigo));
//         tr.appendChild(crearCelda(prod.nombre));
//         tr.appendChild(crearCelda(prod.descripcion));
//         tr.appendChild(crearCelda(prod.precio));
//         tr.appendChild(btn_eliminar); 

//         tablaseleccionados.appendChild(tr);
        
//     });
    
//     btn_eliminar.addEventListener("click", () => {
//         tr.remove(); 
//     }); 
// }

// function seleccionarProductos(){
//     const tablaseleccionados = document.getElementById("tabla_seleccionados"); 
//     tablaseleccionados.innerHTML = "";
    
//     const filas = document.querySelectorAll("#cuerpo_tabla tr");  

//     filas.forEach(fila => {
//         fila.addEventListener("click", () => {
//             const tr = document.createElement("tr");
//             const celdas = fila.querySelectorAll("td");  
 
//             tr.appendChild(crearCelda(celdas[0].textContent)); 
//             tr.appendChild(crearCelda(celdas[1].textContent)); 
//             tr.appendChild(crearCelda(celdas[3].textContent)); 
//             tr.appendChild(crearCelda(celdas[4].textContent)); 
            
//             tablaseleccionados.appendChild(tr); 
//         });
        
//     });
// }

document.addEventListener("DOMContentLoaded", async () => {
    await cargarProductos(); 
});