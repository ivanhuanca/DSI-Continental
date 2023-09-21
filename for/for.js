const btns = document.getElementsByClassName('btn')
console.log(btns)
for (let i = 0; i < btns.length; i++) {
    const element = btns[i];
    const funcion = element.dataset.funcion
    element.addEventListener('click', window[funcion])
}

//Pide al usuario un número n entero positivo
//Responder si se trata de un número primo o no
//Mostrar el resultado en la consola

function numero_primo() {
    const n = parseInt(prompt('Ingrese un número:'));

    //determinar entero positivo
    if (n <= 0) {
        console.log('ingrese un numero positivo')
    } else {

    }

    let primo = 0;
    for (let i = 1; i < n; i++) {
        if (Number.isInteger(n / i)) {
            primo++
        }
    }
    if (primo < 3) {
        console.log(n + ' es un número primo')
    } else {
        console.log(n + ' no es un número primo')
    }
}

function fibonacci(){
    let n = parseInt(prompt('ingrese un numero entero positivo: '))
    let n1 = 0
    let n2 = 1
    let contador = 0
    while (contador < n) {
        console.log(n2)
        let temp = n1 + n2

        n1 = n2
        n2 = temp
        contador++
    }
}