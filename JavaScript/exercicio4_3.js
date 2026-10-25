function maximo(lista) {
    //Caso base: se a lista tiver apenas um elemento, ele e o maior
    if (lista.length === 1) {
        return lista[0];
    }

    //Caso recursivo: acha o maximo do resto da lista
    let subMaximo = maximo(lista.slice(1));

    //Compara o primeiro elemento com o maximo do restante
    return lista[0] > subMaximo ? lista[0] : subMaximo;
}