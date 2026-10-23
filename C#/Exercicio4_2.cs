using System.Collections.Generic; // Importa a biblioteca System.Collections.Generic para utilizar listas genéricas
using System.Linq; // Importa a biblioteca System.Linq para utilizar consultas LINQ

public class Exercicio4_2
{
    public static int Conta(List<int> lista)
    {
        //Caso base: lista vazia tem 0 itens
        if (lista.Count == 0)
        {
            return 0;
        }
        //Caso recursivo: 1 (referente ao primeiro item) + conta o resto
        return 1 + Conta(lista.Skip(1).ToList());
    }
}