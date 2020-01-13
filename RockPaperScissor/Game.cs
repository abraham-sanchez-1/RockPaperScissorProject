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
        int gameMode = 0;
                    //constructor
        public Game()
        {
            int GameModeChoice = SingleOrMultiplayer();
            if (GameModeChoice == 1)
            {
                gameMode = 1;
                Human human1 = new Human("Player 1");
                Human human2 = new Human("Player 2");
            }
            else
            {
                gameMode = 2;
                Human human1 = new Human("Player 1");
                Robot robot = new Robot("Computer  1");
            }
        }
        

                    //member method
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

            //SingleOrMultiplayer()
            //while player is at or below 2 && while player2 is at or below 2
            //methods below will begin the game
            //player selection
            //second player selection
            //firstplayer.selectoption
            //secondplayer.selectoption
            //compare selected options against each other and declare winner



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

        }
        public void MultiPlayer()
        {

        }

    }
}
