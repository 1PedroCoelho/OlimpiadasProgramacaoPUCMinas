using System;

class URI
{

    static void Main(string[] args)
    {

        while (true)
        {


            string[] hora = Console.ReadLine().Split(' ');

            if (hora[0] == "0" && hora[1] == "0" && hora[2] == "0" && hora[3] == "0")
                return;

            int h1 = int.Parse(hora[0]);
            int m1 = int.Parse(hora[1]);

            int h2 = int.Parse(hora[2]);
            int m2 = int.Parse(hora[3]);

            int minutos1 = h1 * 60 + m1;
            int minutos2 = h2 * 60 + m2;
            int diferenca = 0;
            if (h2 == h1)
            {
                if (m2 > m1)
                {
                    diferenca = minutos2 - minutos1;
                }
                else
                {
                    diferenca = ((24 * 60)- minutos1 ) + minutos2;
                }
            }
            else if (h2 < h1)
            {
                diferenca = ((24 * 60)- minutos1 ) + minutos2;
            }
            else
            {
                diferenca = minutos2 - minutos1;
            }
            Console.WriteLine(diferenca);
        }

    }

}