using System;

class URI
{

    static void Main(string[] args)
    {

        while(true)
        {
            string x = Console.ReadLine();

            if(x =="0") return;
            long anagramas=1;
            for(int i=2; i<=x.Length;i++)
            {
                anagramas*=i;
            }
            Console.WriteLine(anagramas);
        }
    }

}