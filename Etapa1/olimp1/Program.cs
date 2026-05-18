using System; 

class URI {

    static void Main(string[] args) { 

       string[] p1 = Console.ReadLine().Split(' ');
       string[] p2 = Console.ReadLine().Split(' ');
       
       double x1 = double.Parse(p1[0]);
       double y1 = double.Parse(p1[1]);
       
       double x2 = double.Parse(p2[0]);
       double y2 = double.Parse(p2[1]);
       
       double dist = Math.Sqrt((Math.Pow(x2-x1, 2))  + (Math.Pow(y2-y1, 2)));
       
       Console.WriteLine($"{dist.ToString("F4")}");
       
    }

}