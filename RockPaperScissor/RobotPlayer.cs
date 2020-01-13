using System;
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
            isHuman = false;

        }
        //Member Method (CAN D0)
        public override int SelectOption()
        {
            int userSelection = 0;
            Console.WriteLine("Please select an option for this round");
            Console.WriteLine("1)Rock\n2)Paper\n3)Scissors\n4)Spocl\n5)Lizard");
            int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    return userSelection;
                default:
                    Console.WriteLine("Not Valid");
                    return SelectOption();

            }
        }
    }
}
