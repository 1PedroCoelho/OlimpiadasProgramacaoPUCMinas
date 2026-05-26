using System;

class Program
{
    static void MergeSort(int[] array, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int meio = (esquerda + direita) / 2;

            MergeSort(array, esquerda, meio);
            MergeSort(array, meio + 1, direita);

            Merge(array, esquerda, meio, direita);
        }
    }

    static void Merge(int[] array, int esquerda, int meio, int direita)
    {
        int tamanho1 = meio - esquerda + 1;
        int tamanho2 = direita - meio;

        int[] left = new int[tamanho1];
        int[] right = new int[tamanho2];

        for (int i = 0; i < tamanho1; i++)
            left[i] = array[esquerda + i];

        for (int j = 0; j < tamanho2; j++)
            right[j] = array[meio + 1 + j];

        int a = 0, b = 0;
        int k = esquerda;

        while (a < tamanho1 && b < tamanho2)
        {
            if (left[a] <= right[b])
            {
                array[k] = left[a];
                a++;
            }
            else
            {
                array[k] = right[b];
                b++;
            }

            k++;
        }

        while (a < tamanho1)
        {
            array[k] = left[a];
            a++;
            k++;
        }

        while (b < tamanho2)
        {
            array[k] = right[b];
            b++;
            k++;
        }
    }

    static void Main()
    {
        int[] numeros = { 38, 27, 43, 3, 9, 82, 10 };

        MergeSort(numeros, 0, numeros.Length - 1);

        Console.WriteLine(string.Join(", ", numeros));
    }
}