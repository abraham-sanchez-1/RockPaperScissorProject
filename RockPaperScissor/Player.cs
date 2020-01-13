using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public abstract class Player
    {
        //member variable
        public string name;
        public int score;

        //constructor
        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
       
        //member method (CAN DO)
        public abstract int SelectOption();


    }
}
