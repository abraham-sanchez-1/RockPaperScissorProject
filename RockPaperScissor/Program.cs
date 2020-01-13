using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            void RunMethod()
            {
                int userSelection = 0;
                Console.WriteLine("Select 1 or 2");
                int.TryParse(Console.ReadLine(), out userSelection);
                switch (userSelection)
                {
                    case 1:
                        userSelection = 1;
                        Console.WriteLine("You have selected 1");
                        break;
                    case 2:
                        userSelection = 2;
                        Console.WriteLine("You have selected 2");
                        break;

                    default:
                        Console.WriteLine("User input was outside of selection");
                        RunMethod();
                        break;
                }
            }
            RunMethod();

        }
    }
}
