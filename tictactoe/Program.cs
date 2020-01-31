using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tour1 = new string[3];
            string[] tour2 = new string[3];
            string[] tour3 = new string[3];

            for(int i = 0; i < tour1.Length; i++)
            {
                tour1[i] = "-";
                tour2[i] = "-";
                tour3[i] = "-";
            }

            for(int turns = 0; turns < 9; turns++)
            {
                Console.WriteLine("  1 2 3");
                for(int cellIndex = 0; cellIndex < 3; cellIndex++)
                {
                    
                    Console.Write((cellIndex + 1) + " " + tour1[cellIndex]);
                    Console.Write(" " + tour2[cellIndex]);
                    Console.Write(" " + tour3[cellIndex]);
                    Console.WriteLine();
                    
                }
                break;
            }
        }
    }
}
