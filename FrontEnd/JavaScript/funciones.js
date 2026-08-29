export function crearCelda(texto){
    const td = document.createElement("td");
    td.textContent = texto;
    return td; 
}

function crearCeldaControl(control){
    const td = document.createElement("td");
    td.appendChild(control);
    return td; 
}

export function crearCeldaImg(rutaImagen, textoAlternativo = "") {
    const img = document.createElement("img");
    img.src = rutaImagen;
    img.alt = textoAlternativo;
    
    return crearCeldaControl(img); 
}

export function crearButton(texto, modo){
    const button = document.createElement("button"); 
    button.style.display = modo; 
    button.textContent = texto; 
    return crearCeldaControl(button);  
}
