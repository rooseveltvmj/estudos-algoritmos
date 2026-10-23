function conta(lista) {
    // Caso base
    if (lista.length === 0) {
        return 0;
    }
    // Caso recursivo
    return 1 + conta(lista.slice(1));
}