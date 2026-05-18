using System; 

class URI {

    static void Main(string[] args) { 

     while(true)
        {
            int qntjogos= int.Parse(Console.ReadLine());
            if(qntjogos ==0)
            {
                return;
            }

            int contjoao=0;
            int contmaria=0;
            string [] partidas = Console.ReadLine().Split(' ');


            for(int i=0; i<qntjogos; i++)
            {
                if(partidas[i]=="0")
                {
                    contmaria++;
                }
                else
                {
                    contjoao++;
                }
            }
            Console.WriteLine($"Mary won {contmaria} times and John won {contjoao} times");
        }
    }

}