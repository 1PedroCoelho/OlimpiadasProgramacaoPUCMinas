using System; 

class URI {

    static void Main(string[] args) { 

        int tempo = int.Parse(Console.ReadLine());
        int velomedia = int.Parse(Console.ReadLine());
       
        double dist = tempo * velomedia;
        
        double consumo = dist/12;

        Console.WriteLine($"{consumo.ToString("F3")}");

    }

}