function esPrimo(numero) {
    let primo = true;
    if (numero <= 1) {
        primo = false;
    }
    for (let i = 2; i < numero; i++) {
        if (numero % i === 0) {
            primo = false;
        }
    }
    if (primo == true){
        console.log("Es un numero primo.")
    }else {
        console.log("No es un numero primo.")
    }
}

esPrimo(3);
esPrimo(8);
esPrimo(17);
esPrimo(73);