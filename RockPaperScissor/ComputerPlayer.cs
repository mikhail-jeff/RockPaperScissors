using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissors.Program;

namespace RockPaperScissors
{
    public class ComputerPlayer : Player
    {
        private static readonly Random random = new Random();

        public ComputerPlayer(string name) : base(name) { }

        public override Choice GetChoice()
        {
            return (Choice)random.Next(3);
        }
    }

}
