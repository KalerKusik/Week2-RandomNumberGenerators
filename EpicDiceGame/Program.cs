using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd1 = new Random();

            int Player1 = rnd1.Next(1, 7);


            Random rnd2 = new Random();

            int Player2 = rnd2.Next(1, 7);

            if (Player1 > Player2)
            {
                Console.WriteLine($"Player 1 number on {Player1} ja Player 2 Number on {Player2}, Player 1 Võitis");
            }

            else if (Player1 < Player2)
            {
                Console.WriteLine($"Player 1 number on {Player1} ja Player 2 Number on {Player2}, Player 2 Võitis");
            }

            else
            {
                Console.WriteLine($"Player 1 number on {Player1} ja Player 2 Number on {Player2}, Viik"); 
            }

        }
    }
}
