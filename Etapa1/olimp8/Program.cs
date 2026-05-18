using System;

class URI
{

    static void Main(string[] args)
    {

        while (true)
        {
            string[] partprob = Console.ReadLine().Split(' ');
            int participantes = int.Parse(partprob[0]);
            int problemas = int.Parse(partprob[1]);

            if (participantes == 0 && problemas == 0)
            {
                return;
            }

            int[,] matriz = new int[participantes, problemas];

            for (int i = 0; i < participantes; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < problemas; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            int caracteristicas = 0;

            bool c1 = true;

            for (int i = 0; i < participantes; i++)
            {
                int soma = 0;
                for (int j = 0; j < problemas; j++)
                {
                    soma += matriz[i, j];
                }
                if (soma == problemas)
                {
                    c1 = false;
                    break;
                }
            }
            if (c1) caracteristicas++;

            bool c2 = true;

            for (int j = 0; j < problemas; j++)
            {
                int soma = 0;
                for (int i = 0; i < participantes; i++)
                {
                    soma += matriz[i, j];
                }
                if (soma == 0)
                {
                    c2 = false;
                    break;
                }
            }
            if (c2) caracteristicas++;

            bool c3 = true;
            for (int j = 0; j < problemas; j++)
            {
                int soma = 0;
                for (int i = 0; i < participantes; i++)
                {
                    soma += matriz[i, j];
                }
                if (soma == participantes)
                {
                    c3 = false;
                    break;
                }
            }
            if (c3) caracteristicas++;

            bool c4 = true;
            for (int i = 0; i < participantes; i++)
            {
                int soma = 0;
                for (int j = 0; j < problemas; j++)
                {
                    soma += matriz[i, j];
                }
                if (soma == 0)
                {
                    c4 = false;
                    break;
                }
            }
            if (c4) caracteristicas++;

            Console.WriteLine(caracteristicas);

        }

    }

}