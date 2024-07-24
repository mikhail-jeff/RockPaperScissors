using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissors.Program;

namespace RockPaperScissors
{

    public abstract class Player
    {
        public string Name { get; private set; }
        public int Health { get; set; } = 3;
        public bool HasPotion { get; set; } = true;

        protected Player(string name)
        {
            Name = name;
        }

        public abstract Choice GetChoice();
    }
}
