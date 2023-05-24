function palabraMasLarga(frase) {
    let palabras = [];
    let palabraMax = "";
    palabras = frase.split(" ");
    palabras.forEach(palabra => {
        if (palabra.length > palabraMax.length){
            palabraMax = palabra;
        }
    });
    console.log(palabraMax);
}

palabraMasLarga("Bienvenidos a la Vueling University de QA automation");