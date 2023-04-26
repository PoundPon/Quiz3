using System;
namespace Code {
    class Program {
        
         static void Main(string[]args){
            int amount = int.Parse(Console.ReadLine());
            string [] place = new string [amount];
            int first;
            int second;
            for (int i = 0; i < amount; i++){
                place[i] = "_";
            }

            do{
                first = int.Parse(Console.ReadLine());
                second = int.Parse(Console.ReadLine());
                if (first == second){ 
                    place[first-1] = "X";
                    for (int i = 0; i < amount; i++){
                        Console.Write("{0} ", place[i]);
                }
                Console.WriteLine();
            }}while (first > 0 || second > 0);
         }
    }
}

