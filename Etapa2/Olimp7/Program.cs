using System;

class URI
{

    static void Main(string[] args)
    {

        string[] Entrada = Console.ReadLine().Split('.');
        int N = int.Parse(Entrada[0]);
        int centavos = int.Parse(Entrada[1]);

        Console.WriteLine("NOTAS:");
        int notas100 = (int)N / 100;
        N = N - notas100 * 100;
        Console.WriteLine($"{notas100} nota(s) de R$ 100.00");

        int notas50 = (int)N / 50;
        N = N - notas50 * 50;
        Console.WriteLine($"{notas50} nota(s) de R$ 50.00");

        int notas20 = (int)N / 20;
        N = N - notas20 * 20;
        Console.WriteLine($"{notas20} nota(s) de R$ 20.00");

        int notas10 = (int)N / 10;
        N = N - notas10 * 10;
        Console.WriteLine($"{notas10} nota(s) de R$ 10.00");

        int notas5 = (int)N / 5;
        N = N - notas5 * 5;
        Console.WriteLine($"{notas5} nota(s) de R$ 5.00");

        int notas2 = (int)N / 2;
        N = N - notas2 * 2;
        Console.WriteLine($"{notas2} nota(s) de R$ 2.00");

        //Moedas
        Console.WriteLine("MOEDAS:");

        int moedas1 = N / 1;
        N = N - moedas1;
        Console.WriteLine($"{moedas1} moeda(s) de R$ 1.00");

        int moedas50 = centavos / 50;
        centavos = centavos - moedas50 * 50;
        Console.WriteLine($"{moedas50} moeda(s) de R$ 0.50");

        int moedas25 = centavos / 25;
        centavos = centavos - moedas25 * 25;
        Console.WriteLine($"{moedas25} moeda(s) de R$ 0.25");

        int moedas10 = centavos / 10;
        centavos = centavos - moedas10 * 10;
        Console.WriteLine($"{moedas10} moeda(s) de R$ 0.10");

        int moedas5 = centavos / 5;
        centavos = centavos - moedas5 * 5;
        Console.WriteLine($"{moedas5} moeda(s) de R$ 0.05");

        Console.WriteLine($"{centavos} moeda(s) de R$ 0.01");
    }

}