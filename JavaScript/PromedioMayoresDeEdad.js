function MayoriaDeEdad(edad) {
    if (edad >= 18){
        return true;
    }else {
        return false
    }
}

function PromedioDeEdad(edades){
    let sumaEdades = 0;
    let personas = 0;
    edades.forEach(edad => {
        if(MayoriaDeEdad(edad)){
            sumaEdades += edad;
            personas++;
        }
    });
    let promedio = sumaEdades / personas;
    console.log("El promedio de edad es de " + promedio + " años.")
}

let arrayEdades = [13 , 40 , 13 , 47 , 29 , 48 , 11 , 57 , 97 , 20 , 48 , 18 , 9 , 14 , 71];
PromedioDeEdad(arrayEdades);