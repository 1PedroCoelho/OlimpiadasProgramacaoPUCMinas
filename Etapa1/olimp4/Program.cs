using System;

class URI
{

    static void Main(string[] args)
    {

        int dias = int.Parse(Console.ReadLine());

        int anos = dias / 365;
        int resto = dias % 365;
        int mes = resto / 30;
        resto =resto%30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{resto} dia(s)");

    }

}