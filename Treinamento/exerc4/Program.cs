using System; 

class URI {

    static void Main(string[] args) { 


        int funcnum = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine());
        double salario = horas*valor;
        Console.WriteLine($"NUMBER = {funcnum}");
        Console.WriteLine("SALARY = U$ "+ salario.ToString("F2"));

    }

}