using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int[] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int [] numeroslidos = numeros.ToArray();
        for (int j = 0; j < numeros.Length - 1; j++)
        {
            int menorindex = j;

            for (int i = j + 1; i < numeros.Length; i++)
            {
                if (numeros[i] < numeros[menorindex])
                {
                    menorindex = i;
                }
            }

            if (menorindex != j)
            {
                int aux = numeros[j];
                numeros[j] = numeros[menorindex];
                numeros[menorindex] = aux;
            }
        }

        foreach (int x in numeros)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();
        foreach (int x in numeroslidos)
        {
            Console.WriteLine(x);
        }
        
    }
}