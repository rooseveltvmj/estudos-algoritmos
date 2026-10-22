function soma(lista) {
    //Caso-base
    if (lista.length === 0){
        return 0;
    }
    //Caso recursivo
    return lista[0] + soma(lista.slice(1));
}