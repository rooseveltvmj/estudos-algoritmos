using System.Collections.Generic;
using System.Linq;

public class Exercicio41
{
    public static int Soma(List<int> lista)
    {
        // Caso base: se a lista estiver vazia, retorna 0
        if (lista.Count == 0)
        {
            return 0;
        }
        // Caso recursivo: primeiro elemento + soma do restante da lista
        return lista[0] + Soma(lista.Skip(1).ToList());
    }
}