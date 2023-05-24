function MayoriaDeEdad(edad) {
    if (edad >= 18){
        console.log("Eres mayor de edad.");
    }else if (edad < 0) {
        console.log("Edad no valida.");
    } else {
        console.log("Eres menor de edad.");
    }
}

MayoriaDeEdad(26);
MayoriaDeEdad(-3);
MayoriaDeEdad(12);