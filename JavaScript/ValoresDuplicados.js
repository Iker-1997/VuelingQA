function DuplicarStrings(palabras) {
    console.log(palabras);
    for (let i = 0; i < palabras.length; i++) {
        palabras[i] = palabras[i].repeat(2); 
    }
    console.log(palabras)
}

function DuplicarNumeros(numeros) {
    console.log(numeros);
    for (let i = 0; i < numeros.length; i++) {
        numeros[i] = numeros[i] * 2; 
    }
    console.log(numeros)
}


DuplicarStrings(["Hola", "me", "llamo", "Iker"]);
DuplicarNumeros([1, 2, 3, 4, 5]);