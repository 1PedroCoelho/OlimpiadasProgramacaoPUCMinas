using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        string[] lavadora = Console.ReadLine().Split(' ');
        int LA = int.Parse(lavadora[0]);
        int LB = int.Parse(lavadora[1]);

        string[] secadora = Console.ReadLine().Split(' ');
        int SA = int.Parse(secadora[0]);
        int SB = int.Parse(secadora[1]);

        if (LA <= N && N <= LB && SA <= N && N <= SB)
        {
            Console.WriteLine("possivel");
        }
        else
        {
            Console.WriteLine("impossivel");
        }

    }

}