using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Game
    {
                    //member variable
        public int gameMode = 0;
        public List<Player> players;

        //constructor
        public Game()
        {


            int GameModeChoice = SingleOrMultiplayer();
            if (GameModeChoice == 1)
            {
                gameMode = 1;
                
                players = new List<Player>() {new Human ("Player 1"), new Robot("computer1")};
            }
            else
            {
                gameMode = 2;
                
                players = new List<Player>() {new Human("Player 1"), new Human("Player 2")};
            }
        }
        
        public void GameRun()
        {
            if(gameMode ==1)
            {
                SinglePlayer();
            }
            else
            {
                MultiPlayer();
            }

        }
        public int SingleOrMultiplayer()
        {
            Console.WriteLine("Welcome to RPSLS: Best of three!\n");
            int userSelection = 0;

            Console.WriteLine("Please select a game mode");
            Console.WriteLine("1)Single-player\n2)Multiplayer");
            int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    Console.WriteLine("You have selected single player!");
                    return userSelection;
                case 2:
                    userSelection = 2;
                    Console.WriteLine("You have selected multiplayer!");
                    return userSelection;
               
                default:
                    Console.WriteLine("The option you selected is not valid");
                    return SingleOrMultiplayer();

            }
        }
        public void SinglePlayer()
        {
            
            while(players[0].score <= 2 && players[1].score <=2)
            {
                int firstSelection; int secondSelection;
                firstSelection = players[0].SelectOption();
                Console.WriteLine("\nComputer will now choose option:\nClick to continue");
                Console.ReadLine();
                secondSelection = players[1].SelectOption();
                SelectWinner(firstSelection, secondSelection);
                
            }
            if(players[0].score == 3)
            {
                Console.WriteLine("{0} has won best out of three!",players[0].name);
            }
            else if (players[1].score == 3)
            {
                Console.WriteLine("{0} has won best out of three!", players[1].name);
            }
            else
            { 
                Console.WriteLine("something is wrong"); 
            }
        }
        public void MultiPlayer()
        {
            while (players[0].score <= 2 && players[1].score <= 2)
            {
                int firstSelection; int secondSelection;
                firstSelection = players[0].SelectOption();
                Console.WriteLine("\nIt is now player 2's turn:");
                secondSelection = players[1].SelectOption();
                Console.WriteLine("");
                SelectWinner(firstSelection, secondSelection);

            }
            if (players[0].score == 3)
            {
                Console.WriteLine("{0} has won best out of three!", players[0].name);
            }
            else if (players[1].score == 3)
            {
                Console.WriteLine("{0} has won best out of three!", players[1].name);
            }
            else
            {
                Console.WriteLine("something is wrong");
            }

        }
        public void SelectWinner(int selectionOne, int selectionTwo)
        {
            int selection;
            int secondselection;
            selection = selectionOne;
            secondselection = selectionTwo;
            if (selection == 1 && secondselection == 1)
            {
                Console.WriteLine("TIE!");
            }
            else if (selection == 1 && secondselection ==2)
            {
                Console.WriteLine("Paper covers rock, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 1 && secondselection == 3)
            {
                Console.WriteLine("Rock crushes scissors, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 1 && secondselection == 4)
            {
                Console.WriteLine("Rock smashes lizard, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 1 && secondselection == 5)
            {
                Console.WriteLine("Spock vaporizes rock, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 2 && secondselection == 1)
            {
                Console.WriteLine("Paper covers rock, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 2 && secondselection == 2)
            {
                Console.WriteLine("TIE!");
            }
            else if (selection == 2 && secondselection == 3)
            {
                Console.WriteLine("Scissor cuts paper, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 2 && secondselection == 4)
            {
                Console.WriteLine("Lizzard eats paper, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 2 && secondselection == 5)
            {
                Console.WriteLine("Paper disproves spock, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 3 && secondselection == 1)
            {
                Console.WriteLine("Rock crushes scissors, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 3 && secondselection == 2)
            {
                Console.WriteLine("Scissors cuts paper, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 3 && secondselection == 3)
            {
                Console.WriteLine("TIE!");
            }
            else if (selection == 3 && secondselection == 4)
            {
                Console.WriteLine("Scissor decapitates lizard, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 3 && secondselection == 5)
            {
                Console.WriteLine("Spock crushes scissors, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 4 && secondselection == 1)
            {
                Console.WriteLine("Rock crushes lizard, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 4 && secondselection == 2)
            {
                Console.WriteLine("Lizard eats paper, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 4 && secondselection == 3)
            {
                Console.WriteLine("Scissor decapitates lizard, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 4 && secondselection == 4)
            {
                Console.WriteLine("TIE!");
            }
            else if (selection == 4 && secondselection == 5)
            {
                Console.WriteLine("Lizzard poisons spock, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 5 && secondselection == 1)
            {
                Console.WriteLine("Spock vaporizes rock, {0} wins the round!", players[0].name);
                players[0].score++;
            }

            else if (selection == 5 && secondselection == 2)
            {
                Console.WriteLine("Paper disproves spock, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 5 && secondselection == 3)
            {
                Console.WriteLine("Spock crushes scissors, {0} wins the round!", players[0].name);
                players[0].score++;
            }
            else if (selection == 5 && secondselection == 4)
            {
                Console.WriteLine("Lizzard poisons spock, {0} wins the round!", players[1].name);
                players[1].score++;
            }
            else if (selection == 5 && secondselection == 5)
            {
                Console.WriteLine("TIE!");
            }



        }
        

    }
}
