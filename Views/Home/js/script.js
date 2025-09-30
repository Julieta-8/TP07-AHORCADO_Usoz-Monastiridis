
const palabra = document.getElementById("Palabra").innerText; 
let resultado = document.getElementById("Resultado");

let letrasIngresadas = [];
let letrasPalabra = palabra.split(""); 
let terminado = document.getElementById("Terminado").innerText;
let perdiste = document.getElementById("Perdiste").innerText;
let intentos = 0;

resultado.innerText = "_".repeat(palabra.length);

function ingresoLetra(letra) {
    if (terminado || perdiste) {return;}

    if (!letrasIngresadas.includes(letra)) {
        letrasIngresadas.push(letra);
        intentos++;

     
        let nuevaSalida = "";
        for (let i = 0; i < letrasPalabra.length; i++) {
            if (letrasIngresadas.includes(letrasPalabra[i])) {
                nuevaSalida += letrasPalabra[i];
            } else {
                nuevaSalida += "_"; // guion
            }
        }

        resultado.innerText = nuevaSalida;

     
        if (!nuevaSalida.includes("_")) {
            Value.terminado = true;
            resultado.innerText = "¡GANÓ!";
        } else if (intentos >= 6) { 
            Value.perdiste = true;
            resultado.innerText = "PERDIÓ";
        }
    }
}


function ingresoPalabra(palabra2) {
    intentos++;
    if (palabra2 === palabra) {
        Value.terminado = true;
        resultado.innerText = "¡GANÓ!";
    } else {
        Value.perdiste = true;
        resultado.innerText = "PERDIÓ";
    }
}


