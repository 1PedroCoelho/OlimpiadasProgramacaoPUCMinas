using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int soma = 0;
        if (x < y)
        {
            for (int i = x; x <= y; x++)
            {
                if (x % 13 == 0)
                {
                    soma = soma - x;
                }
                soma += x;
            }
        }
        else
        {
               for (int i = y; y <= x; y++)
            {
                if (y % 13 == 0)
                {
                    soma = soma - y;
                }
                soma += y;
            }
        }


        Console.WriteLine(soma);
    }

}