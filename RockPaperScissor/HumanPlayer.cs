using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Human : Player //Inheritance (IS A TYPE OF)
    {
        //Member Variable (HAS A)

        //Constructor (SPAWNER)
        public Human(string name, bool isHuman)
        {
            this.name = name;
            this.isHuman = isHuman;

        }


        //Member Method (CAN DO)
        public override int SelectOption()
        {
            int userSelection;
       
                Console.WriteLine("Please select an option for this round");
                Console.WriteLine("1)Rock\n2)Paper\n3)Scissors\n4)Spocl\n5)Lizard");
                int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                default:
                    Console.WriteLine("Not Valid");
                    return SelectOption();
                    
            }
        }
        public int SelectionOutsideOfParameter()
        {
            Console.WriteLine("Invalid Entry: Please select integer from list");
            int retry = SelectOption();
            return retry;
        }
    }
}
