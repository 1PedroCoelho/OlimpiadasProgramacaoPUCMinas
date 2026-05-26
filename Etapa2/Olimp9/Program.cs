using System;

class URI
{

    static void Main(string[] args)
    {
        int caso = 1;
        while (true)
        {
            string linha = Console.ReadLine();

            if (linha == null)
            {
                break;
            }

            int N = int.Parse(linha);

            string[] valores = Console.ReadLine().Split(' ');
            double[] digitos = new double[10];
            for (int i = 0; i < valores.Length; i++)
            {
                double x = double.Parse(valores[i]);
                digitos[i] = x;
            }



            int[] indices = new int[digitos.Length];

            int indx = 0;

            for (int j = 0; j < digitos.Length; j++)
            {
                double maior = -1;
                int maiorindx = 0;

                for (int k = 0; k < digitos.Length; k++)
                {
                    if (digitos[k] > maior)
                    {
                        maior = digitos[k];
                        maiorindx = k;
                    }
                }

                digitos[maiorindx] = -1;

                indices[indx] = maiorindx;
                indx++;
            }

            Console.Write($"Caso {caso}: ");
            for (int l = 0; l < N; l++)
            {
                Console.Write($"{indices[l]}");
            }
            Console.WriteLine();
            caso++;
        }

    }

}