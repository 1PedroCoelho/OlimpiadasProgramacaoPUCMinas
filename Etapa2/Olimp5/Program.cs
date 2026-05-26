using System;

class URI
{

    static void Main(string[] args)
    {

        while (true)
        {
            string entrada = Console.ReadLine();
            string[] linha = entrada.Split('=');

            string[] conta = linha[0].Split('+');

            string result = linha[1];
            char[] chars2 = result.ToCharArray();
            Array.Reverse(chars2);
            string resultado = new string(chars2);

            string firstNumber = conta[0];
            char[] chars = firstNumber.ToCharArray();
            Array.Reverse(chars);
            string invertidoA = new string(chars);

            string secondNumber = conta[1];
            char[] chars1 = secondNumber.ToCharArray();
            Array.Reverse(chars1);
            string invertidoB = new string(chars1);

            int resultado1 = int.Parse(resultado);
            int invertidoA1 = int.Parse(invertidoA);
            int invertidoB1 = int.Parse(invertidoB);

            if (resultado1 == invertidoA1 + invertidoB1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (entrada == "0+0=0") break;
        }
    }

}