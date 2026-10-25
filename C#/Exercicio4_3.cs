using System.Collections.Generic;
using System.Linq;

public class Exercicio4_3
{
    public static int Maximo(Liste<int> numeros)
    {
        //Caso base: se a lista estiver apenas 1 elemento, ele retorna esse elemento
        if (lista.Count == 1)
        {
            return lista[0];
        }

        //Caso recursivo: acha o maximo do resto da lista
        int subMaximo = Maximo(lista.Skip(1).ToList());

        //Compara o primeiro elemento com o maximo do resto da lista
        return lista[0] > subMaximo ? lista[0] : subMaximo;
    }
}