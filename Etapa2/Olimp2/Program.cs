using System;

class URI
{
    static void Main(string[] args)
    {
        int casostestes = int.Parse(Console.ReadLine());

        for (int i = 0; i < casostestes; i++)
        {
            string[] cidades = Console.ReadLine().Split(' ');

            int PA = int.Parse(cidades[0]);
            int PB = int.Parse(cidades[1]);

            double GA = double.Parse(cidades[2]);
            double GB = double.Parse(cidades[3]);

            int anos = 0;

            while (PA <= PB)
            {
                PA += (int)(PA * GA / 100);
                PB += (int)(PB * GB / 100);

                anos++;

                if (anos > 100)
                    break;
            }

            if (anos > 100)
                Console.WriteLine("Mais de 1 seculo.");
            else
                Console.WriteLine($"{anos} anos.");
        }
    }
}