﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Robot : Player //Inheritace (IS A TYPE OF)
    {
        //Member Variable (HAS A)

        //Constructor (SPAWNER)
        public Robot(string name)
        {
            this.name = name;

        }
        //Member Method (CAN D0)
        public override int SelectOption()
        {
            String[] Options = new String[] { "rock", "paper", "scissor", "spock", "lizard"};
            Random random = new Random();
            int userSelection = random.Next(1,5);
            Console.WriteLine("{0} has selected " + Options[userSelection] + "!", name);
            return userSelection;
            
        }
    }
}