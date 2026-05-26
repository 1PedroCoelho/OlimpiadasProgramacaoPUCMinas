using System;

class URI
{

    static void Main(string[] args)
    {
        int jogadas = 0;
        do
        {
            jogadas = int.Parse(Console.ReadLine());

            int pontosA = 0;
            int pontosB = 0;

            for (int i = 0; i < jogadas; i++)
            {
                string[] jogo = Console.ReadLine().Split(' ');

                int A = int.Parse(jogo[0]);
                int B = int.Parse(jogo[1]);

                if (A > B)
                    pontosA++;
                else if (B > A)
                    pontosB++;
                else;
            }
            if (jogadas != 0)
                Console.WriteLine(pontosA + " " + pontosB);
        } while (jogadas != 0);


    }

}