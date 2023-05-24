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
    return primo;
}

function primerosPrimos() {
    let numerosPrimos = [];
    let contador = 2;

    while (numerosPrimos.length < 10){
        if(esPrimo(contador)){
            numerosPrimos.push(contador);
        }
        contador++;
    }
    console.log(numerosPrimos);
}

primerosPrimos();