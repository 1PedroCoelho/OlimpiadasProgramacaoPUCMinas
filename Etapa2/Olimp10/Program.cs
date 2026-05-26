using System;


class URI {

    static void Main(string[] args) { 

       string [] linha = Console.ReadLine().Split(' ');

       int P = int.Parse(linha[0]);
       int R = int.Parse(linha[1]);
    
        if(P==0)
        {
            Console.WriteLine("C");
        }
        else if(R==0)
        {
            Console.WriteLine("B");
        }
        else Console.WriteLine("A");
    }

}