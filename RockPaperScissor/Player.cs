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
        public bool isHuman;

        //constructor
       
        //member method (CAN DO)
        public abstract int SelectOption();


    }
}
