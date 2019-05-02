using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Game
    {
        //has these
        /*Player PlayerTwo;
        InputValidation Validate;
        Player PlayerOne;
        Gestures2 MadeGestures;
        string MatchCount;
        string KeepPlaying;
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;
        double MatchCountInt;
        double MatchHalf;
        double round;
        double[] GridSize;
        */

        //Constructor
        public Game()
        {
            /*
            Validate = new InputValidation();
            PlayerOne = new HumanPlayer();
            MadeGestures = new Gestures2();
            round = 0;
            */

        }

        //does this
        public void RunGame()
        {
            /*
            if (round == 0)
            {
                EnterMainMenu();
            }
            StartGame();
            DecideWinner();
            CalculateSeriesLeader();
            CheckForGameOver(MatchCountInt);
            DisplaySeriesWinner();
            */
    }
    /*
    public void EnterMainMenu()
    {
        Console.WriteLine("Welcome to Battleship.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
        string PlayerTwoAIStatus = Console.ReadLine().ToLower();
        Validate.IsItValid(PlayerTwoAIStatus);
        Console.WriteLine("Would you like to play 1 time or play a series to the best of 3, 5, or 7?");
        MatchCount = Console.ReadLine().ToLower();
        MatchCountInt = int.Parse(MatchCount);
        Console.WriteLine("What size would you like the gameboard to be? (Equal height and width between 20 and 30)");
        GridSize = Console.ReadLine()

        if (PlayerTwoAIStatus == "human")
        {
            PlayerTwo = new Human();
        }
        else if (PlayerTwoAIStatus == "ai")
        {
            PlayerTwo = new CPU();
        }



    }

    public void StartGame()
    {
        ChoiceOne = PlayerOne.ChooseYourTarget();
        ChoiceTwo = PlayerTwo.ChooseYourTarget();

    }

    public void DecideWinner()
    {
        WhoWon = Player.ThisPlayerWon();
    }

    public void CalculateSeriesLeader()
    {

        if (WhoWon == "PlayerOne")
        {
            PlayerOne.ThisPlayerWon();
        }
        else if (WhoWon == "PlayerTwo")
        {
            PlayerTwo.ThisPlayerWon();
        }
        else
        {
            PlayerOne.NoPlayerWon();
        }
    }

    public void CheckForGameOver(double Matches)
    {
        MatchHalf = Matches / 2;
        while (PlayerOne.WinCount < MatchHalf && PlayerTwo.WinCount < MatchHalf)
        {
            Console.WriteLine($"The win count (Best of {Matches}) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
            KeepPlaying = Console.ReadLine().ToLower();
            Validate.IsItValid(KeepPlaying);
            if (KeepPlaying == "yes")
            {
                round++;
                RunGame();
            }
            else
            {
                Console.WriteLine("Then close the console you quitter");
                Console.ReadLine();
            }
        }
    }

    public void DisplaySeriesWinner()
    {

        Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG EZ");
        Console.ReadLine();

    }
    */
}
}
