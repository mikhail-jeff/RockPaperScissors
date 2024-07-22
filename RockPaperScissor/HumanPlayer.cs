using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissors.Program;

namespace RockPaperScissors
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override Choice GetChoice()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your choice (rock, paper, scissors, or potion): ");
                    string input = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    Choice choice;

                    switch (input)
                    {
                        case "rock":
                            choice = Choice.Rock;
                            break;
                        case "paper":
                            choice = Choice.Paper;
                            break;
                        case "scissors":
                            choice = Choice.Scissors;
                            break;
                        case "potion":
                            choice = Choice.Potion;
                            break;
                        default:
                            throw new ArgumentException("Invalid input, please enter rock, paper, scissors, or potion.");
                    }

                    return choice;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }

}
