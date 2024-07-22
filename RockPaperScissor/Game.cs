using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissors.Program;

namespace RockPaperScissors
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors,
        Potion
    }

    public class Game
    {
        private HumanPlayer player;
        private ComputerPlayer computer;

        public Game(string playerName)
        {
            player = new HumanPlayer(playerName);
            computer = new ComputerPlayer("Computer");
        }


        public void Start()
        {
            while (player.Health > 0 && computer.Health > 0)
            {
                try
                {
                    PlayTurn();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            DisplayResult();
        }


        private void PlayTurn()
        {
            Choice playerChoice = player.GetChoice();

            if (playerChoice == Choice.Potion)
            {
                if (player.HasPotion && player.Health < 3)
                {
                    player.Health++;
                    player.HasPotion = false;
                    Console.WriteLine("You used the potion and gained 1 health point.");
                    Console.WriteLine($"Player Health: {player.Health}, Computer Health: {computer.Health}");
                    Console.WriteLine();
                }
                else if (!player.HasPotion)
                {
                    Console.WriteLine("You have no potion left!");
                }
                else if (player.Health == 3)
                {
                    Console.WriteLine("Your health is full. You cannot use the potion.");
                }

                return;
            }

            Choice computerChoice = computer.GetChoice();

            Console.WriteLine($"You chose {playerChoice.ToString().ToUpper()}. Computer chose {computerChoice.ToString().ToUpper()}.");

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a TIE!");
            }
            else if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                     (playerChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                     (playerChoice == Choice.Scissors && computerChoice == Choice.Paper))
            {
                computer.Health--;
                Console.WriteLine("You WON this turn!");
            }
            else
            {
                if (player.Health == 1 && player.HasPotion)
                {
                    if (new Random().Next(2) == 0)
                    {
                        player.HasPotion = false;
                        Console.WriteLine("Your potion saved you from death!");
                    }
                    else
                    {
                        player.Health--;
                        Console.WriteLine("You LOST this turn!");
                    }
                }
                else
                {
                    player.Health--;
                    Console.WriteLine("You LOST this turn!");
                }
            }

            Console.WriteLine($"Player Health: {player.Health}, Computer Health: {computer.Health}");
        }


        private void DisplayResult()
        {
            if (player.Health > 0)
            {
                Console.WriteLine("You WON!");
            }
            else
            {
                Console.WriteLine("You LOST!");
            }
        }
    }

}
