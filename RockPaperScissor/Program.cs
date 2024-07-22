using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            while (true)
            {
                try
                {
                    Console.Write("Enter your name: ");
                    string playerName = Console.ReadLine();

                    Game game = new Game(playerName);

                    game.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.Write($"Do you want to play again? (Y/N): ");
                char playAgain = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToLower(playAgain) != 'y')
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
