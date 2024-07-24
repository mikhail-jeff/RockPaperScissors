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

            Console.WriteLine("Welcome to ROCK PAPER SCISSORS GAME!");
            Console.WriteLine();


            while (true)
            {
                string playerName = string.Empty;

                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Enter your name: ");
                        playerName = Console.ReadLine();

                        // Check for empty name
                        if (string.IsNullOrWhiteSpace(playerName))
                        {
                            throw new ArgumentException("Name cannot be empty. Please enter a valid name.");
                            Console.WriteLine();
                        }

                        // Check if name consists solely of numbers
                        if (playerName.All(char.IsDigit))
                        {
                            throw new ArgumentException("Name cannot consist solely of numbers. Please enter a valid name.");
                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                Game game = new Game(playerName);
                game.Start();

                char playAgain;

                while (true)
                {
                    Console.Write("Do you want to play again? (Y/N): ");
                    playAgain = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (char.ToLower(playAgain) == 'y' || char.ToLower(playAgain) == 'n')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                    }
                }

                if (char.ToLower(playAgain) != 'y')
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
