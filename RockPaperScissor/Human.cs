using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Human : Player //Inheritance (IS A TYPE OF)
    {
        //Member Variable (HAS A)

        //Constructor (SPAWNER)
        public Human(string name) 
        {
            this.name = name;
        }


        //Member Method (CAN DO)
        public override int SelectOption()
        {
            int userSelection = 0;
       
                Console.WriteLine("Please select an option for this round");
                Console.WriteLine("1)Rock\n2)Paper\n3)Scissors\n4)Lizard\n5)Spock");
                int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    Console.WriteLine("You have selected rock!");
                    return userSelection;
                case 2:
                    userSelection = 2;
                    Console.WriteLine("You have selected paper!");
                    return userSelection;
                case 3:
                    userSelection = 3;
                    Console.WriteLine("You have selected scissor!");
                    return userSelection;
                case 4:
                    userSelection = 4;
                    Console.WriteLine("You have selected lizard!");
                    return userSelection;
                case 5:
                    userSelection = 5;
                    Console.WriteLine("You have selected spock!");
                    return userSelection;
                default:
                    Console.WriteLine("The option you selected is not valid");
                    return SelectOption();
                    
            }
        }
    }
}
