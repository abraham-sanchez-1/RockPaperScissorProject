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
        public List<String> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        //constructor
        public Game()
        {

            IntroMenu();
            SingleOrMultiplayer();
            if (gameMode == 1)
            {   
                players = new List<Player>() {new Human ("Player 1"), new Robot()};
            }
            else
            {              
                players = new List<Player>() {new Human("Player 1"), new Human("Player 2")};
            }
        }
        
        public void GameRun()
        {

            //if (gameMode == 1)
            //{
                GamePlay();
            //}
            //else
            //{
            //    MultiPlayer();
            //}

        }
        public void SingleOrMultiplayer()
        {
            int userSelection = 0;

            Console.WriteLine("Please select a game mode");
            Console.WriteLine("1)Single-player\n2)Multiplayer");
            int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    Console.WriteLine("You have selected single player!");
                    gameMode = userSelection;
                    break;
                case 2:
                    userSelection = 2;
                    Console.WriteLine("You have selected multiplayer!");
                    gameMode = userSelection;
                    break;

                default:
                    Console.WriteLine("The option you selected is not valid");
                    gameMode = userSelection;
                    break;

            }
        }
        public void GamePlay()
        {
            
            while(players[0].score < 2 && players[1].score < 2)
            {
                int firstSelection; int secondSelection;
                Console.WriteLine("{0}'s turn", players[0].name);
                firstSelection = players[0].SelectOption();
                Console.WriteLine("{0}'s turn", players[1].name);
                secondSelection = players[1].SelectOption();
                SelectWinner(firstSelection, secondSelection);
                
            }
            if(players[0].score == 2)
            {
                Console.WriteLine("{0} has won best out of three!",players[0].name);
            }
            else if (players[1].score == 2)
            {
                Console.WriteLine("{0} has won best out of three!", players[1].name);
            }
            else
            { 
                Console.WriteLine("something is wrong"); 
            }
            GameEnd();
        }
        //public void MultiPlayer()
        //{
        //    while (players[0].score < 2 && players[1].score < 2)
        //    {
        //        int firstSelection; int secondSelection;
        //        Console.WriteLine("\nPlayer 1 turn:");
        //        firstSelection = players[0].SelectOption();
        //        Console.WriteLine("\nIt is now player 2's turn:");
        //        secondSelection = players[1].SelectOption();
        //        Console.WriteLine("");
        //        SelectWinner(firstSelection, secondSelection);

        //    }
        //    if (players[0].score == 2)
        //    {
        //        Console.WriteLine("{0} has won best out of three!", players[0].name);
        //    }
        //    else if (players[1].score == 2)
        //    {
        //        Console.WriteLine("{0} has won best out of three!", players[1].name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("something is wrong");
        //    }
        //    GameEnd();

        //}
        public void SelectWinner(int selectionOne, int selectionTwo)
        {
            int selection;
            int secondSelection;
            selection = selectionOne;
            secondSelection = selectionTwo;
            if (selection == 1)
            {
                if (secondSelection == 1)
                { 
                    Console.WriteLine("TIE!"); 
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else if (secondSelection == 3 || secondSelection == 4)
                {
                    //player 1 winner
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[selection - 1], gestures[secondSelection - 1], players[0].name);
                    players[0].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else
                {
                    //player 1 loser
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[secondSelection - 1], gestures[selection - 1], players[1].name);
                    players[1].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
            }
            if (selection == 2)
            {
                if (secondSelection == 2)
                {
                    Console.WriteLine("TIE!");
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else if (secondSelection == 1 || secondSelection == 5)
                {
                    //player 1 winner
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[selection - 1], gestures[secondSelection - 1], players[0].name);
                    players[0].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else
                {
                    //player 1 loser
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[secondSelection - 1], gestures[selection - 1], players[1].name);
                    players[1].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
            }
            if (selection == 3)
            {
                if (secondSelection == 3)
                {
                    Console.WriteLine("TIE!");
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else if (secondSelection == 2 || secondSelection == 4)
                {
                    //player 1 winner
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[selection - 1], gestures[secondSelection - 1], players[0].name);
                    players[0].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else
                {
                    //player 1 loser
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[secondSelection - 1], gestures[selection - 1], players[1].name);
                    players[1].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
            }
            if (selection == 4)
            {
                if (secondSelection == 4)
                {
                    Console.WriteLine("TIE!");
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else if (secondSelection == 2 || secondSelection == 5)
                {
                    //player 1 winner
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[selection - 1], gestures[secondSelection - 1], players[0].name);
                    players[0].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else
                {
                    //player 1 loser
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[secondSelection - 1], gestures[selection - 1], players[1].name);
                    players[1].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
            }
            if (selection == 5)
            {
                if (secondSelection == 5)
                {
                    Console.WriteLine("TIE!");
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else if (secondSelection == 1 || secondSelection == 3)
                {
                    //player 1 winner
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[selection - 1], gestures[secondSelection - 1], players[0].name);
                    players[0].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
                else
                {
                    //player 1 loser
                    Console.WriteLine("{0} beats {1}, {2} wins!", gestures[secondSelection - 1], gestures[selection - 1], players[1].name);
                    players[1].score++;
                    Console.WriteLine("Click to continue");
                    Console.ReadLine();
                }
            }

            //if (selection == 1 && secondSelection == 1)
            //{
            //    Console.WriteLine("TIE!");
            //}
            //else if (selection == 1 && secondSelection ==2)
            //{
            //    Console.WriteLine("Paper covers rock, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 1 && secondSelection == 3)
            //{
            //    Console.WriteLine("Rock crushes scissors, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 1 && secondSelection == 4)
            //{
            //    Console.WriteLine("Rock smashes lizard, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 1 && secondSelection == 5)
            //{
            //    Console.WriteLine("Spock vaporizes rock, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 2 && secondSelection == 1)
            //{
            //    Console.WriteLine("Paper covers rock, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 2 && secondSelection == 2)
            //{
            //    Console.WriteLine("TIE!");
            //}
            //else if (selection == 2 && secondSelection == 3)
            //{
            //    Console.WriteLine("Scissor cuts paper, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 2 && secondSelection == 4)
            //{
            //    Console.WriteLine("Lizzard eats paper, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 2 && secondSelection == 5)
            //{
            //    Console.WriteLine("Paper disproves spock, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 3 && secondSelection == 1)
            //{
            //    Console.WriteLine("Rock crushes scissors, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 3 && secondSelection == 2)
            //{
            //    Console.WriteLine("Scissors cuts paper, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 3 && secondSelection == 3)
            //{
            //    Console.WriteLine("TIE!");
            //}
            //else if (selection == 3 && secondSelection == 4)
            //{
            //    Console.WriteLine("Scissor decapitates lizard, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 3 && secondSelection == 5)
            //{
            //    Console.WriteLine("Spock crushes scissors, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 4 && secondSelection == 1)
            //{
            //    Console.WriteLine("Rock crushes lizard, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 4 && secondSelection == 2)
            //{
            //    Console.WriteLine("Lizard eats paper, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 4 && secondSelection == 3)
            //{
            //    Console.WriteLine("Scissor decapitates lizard, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 4 && secondSelection == 4)
            //{
            //    Console.WriteLine("TIE!");
            //}
            //else if (selection == 4 && secondSelection == 5)
            //{
            //    Console.WriteLine("Lizzard poisons spock, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 5 && secondSelection == 1)
            //{
            //    Console.WriteLine("Spock vaporizes rock, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 5 && secondSelection == 2)
            //{
            //    Console.WriteLine("Paper disproves spock, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 5 && secondSelection == 3)
            //{
            //    Console.WriteLine("Spock crushes scissors, {0} wins the round!", players[0].name);
            //    players[0].score++;
            //}
            //else if (selection == 5 && secondSelection == 4)
            //{
            //    Console.WriteLine("Lizzard poisons spock, {0} wins the round!", players[1].name);
            //    players[1].score++;
            //}
            //else if (selection == 5 && secondSelection == 5)
            //{
            //    Console.WriteLine("TIE!");
            //}



        }
        public void IntroMenu()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard Spock!");
            Console.WriteLine("Rules are simple, best of three!\nOptions are:\n\nRock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
        }
        public void GameEnd()
        {
            int userSelection = 0;

            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1)Yes\n2)No");
            int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    Console.WriteLine("Resetting game!");
                    players.Clear();
                    SingleOrMultiplayer();
                    if (gameMode == 1)
                    {
                        players = new List<Player>() { new Human("Player 1"), new Robot() };
                    }
                    else
                    {
                        players = new List<Player>() { new Human("Player 1"), new Human("Player 2") };
                    }
                    GameRun();

                    break;
                case 2:
                    userSelection = 2;
                    Console.WriteLine("Byeeeeeeee!");
                    break;
                default:
                    Console.WriteLine("Option selected was invalid");
                    GameEnd();
                        break;

            }
        }
    }
}
