using System; 

class URI {

    static void Main(string[] args) { 

       string[]numeros = Console.ReadLine().Split(' ');
       int num1= int.Parse(numeros[0]);
       int num2= int.Parse(numeros[1]);
       int num3= int.Parse(numeros[2]);
       
       int maior =0;
       
       if(num1> maior)
       {
           maior=num1;
       }
       if(num2>maior)
       {
           maior = num2;
       }
       if (num3>maior)
       {
           maior=num3;
       }
       
       Console.WriteLine($"{maior} eh o maior");
       
        
        
    }

}