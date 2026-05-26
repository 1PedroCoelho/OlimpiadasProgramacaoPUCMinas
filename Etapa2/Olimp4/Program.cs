using System;

class URI
{

    static void Main(string[] args)
    {
        int casostestes = int.Parse(Console.ReadLine());
        for (int i = 0; i < casostestes; i++)
        {
            string[] jognum = Console.ReadLine().Split(' ');

            int qntjog = int.Parse(jognum[0]);
            int numsort = int.Parse(jognum[1]);

            string[] chutes = Console.ReadLine().Split(' ');

            int[] diferencas = new int[qntjog];
            for (int j = 0; j < chutes.Length; j++)
            {

                int teste = int.Parse(chutes[j]);
                int dif = 0;
                if (teste >= numsort)
                {
                    dif = teste - numsort;
                }
                else dif = numsort - teste;

                diferencas[j] = dif;
            }
            int menor = int.MaxValue;
            int posit = -1;
            for (int k = 0; k < diferencas.Length; k++)
            {
                if (diferencas[k] < menor)
                {
                    menor = diferencas[k];
                    posit = k;
                }
            }
            Console.WriteLine(posit + 1);
        }

    }

}