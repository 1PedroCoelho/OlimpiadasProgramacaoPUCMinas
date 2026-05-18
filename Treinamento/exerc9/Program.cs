using System; 

class URI {

    static void Main(string[] args) { 

         string cha = Console.ReadLine();

        string[] chutes = Console.ReadLine().Split(' ');

        int acertos = 0;

        foreach (string c in chutes)
        {
            if (c == cha)
            {
                acertos++;
            }
        }

        Console.WriteLine(acertos);

    }

}