using System; 

class URI {

    static void Main(string[] args) { 

    
    
        int dist = int.Parse(Console.ReadLine());
        double litros = double.Parse(Console.ReadLine());
        double consumo = dist/litros;
        Console.WriteLine(consumo.ToString("F3")+" km/l");
    }

}