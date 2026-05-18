using System;

class URI
{

    static void Main(string[] args)
    {
        while (true)
        {
            int consultas = int.Parse(Console.ReadLine());
            if(consultas == 0)
                return;
            string[] pontodivisor = Console.ReadLine().Split(' ');
            int pontox = int.Parse(pontodivisor[0]);
            int pontoy = int.Parse(pontodivisor[1]);

            for (int i = 0; i < consultas; i++)
            {
                string[] pontocasa = Console.ReadLine().Split(' ');
                int casax = int.Parse(pontocasa[0]);
                int casay = int.Parse(pontocasa[1]);
                
                if(casax == pontox || casay == pontoy)
                {
                    Console.WriteLine("divisa");
                }
                else if (casax > pontox && casay > pontoy)
                {
                    Console.WriteLine("NE");
                }
                else if (casax < pontox && casay > pontoy)
                {
                    Console.WriteLine("NO");
                }
                else if (casax > pontox && casay < pontoy)
                {
                    Console.WriteLine("SE");
                }
                else if (casax < pontox && casay < pontoy)
                {
                    Console.WriteLine("SO");
                }

            }
        }
    }

}