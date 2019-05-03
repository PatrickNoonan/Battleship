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
        Player PlayerTwo;
        Player PlayerOne;
        /*InputValidation Validate;
        Gestures2 MadeGestures;        
        string KeepPlaying;
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;        
        double round;
        double[] GridSize;
        */
        public GameBoard MyGameBoard;
        public string MatchCount;
        public double MatchCountInt;
        public double MatchHalf;

        //Constructor
        public Game()
        {
            /*
            Validate = new InputValidation();            
            MadeGestures = new Gestures2();
            round = 0;
            */
            PlayerOne = new Human();
            MyGameBoard = new GameBoard();

        }

        //does this
        public void RunGame()
        {
            //if (round == 0)
            //{
            EnterMainMenu();
            //}
            MyGameBoard.IstantiateCoordinates();
            SetShips();
            StartGame();
            //DecideWinner();
            //CalculateSeriesLeader();
            //CheckForGameOver(MatchCountInt);
            //DisplaySeriesWinner();

        }
        public void EnterMainMenu()
        {
            Console.WriteLine("Welcome to Battleship.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
            string PlayerTwoAIStatus = Console.ReadLine().ToLower();
            //Validate.IsItValid(PlayerTwoAIStatus);
            Console.WriteLine("Would you like to play 1 time or play a series to the best of 3, 5, or 7?");
            MatchCount = Console.ReadLine().ToLower();
            MatchCountInt = int.Parse(MatchCount);
            MyGameBoard.UsersChoiceOfSize();


            if (PlayerTwoAIStatus == "human")
            {
                PlayerTwo = new Human();
            }
            else if (PlayerTwoAIStatus == "ai")
            {
                PlayerTwo = new CPU();
            }
        }


        public void SetShips()
        {
            List<int> ShipLocationP1 = PlayerOne.PlaceYourShip("PlayerOne");
            List<int> ShipLocationP2 = PlayerTwo.PlaceYourShip("PlayerTwo");
            MyGameBoard.MarkShipLocation(ShipLocationP1[0], ShipLocationP1[1], "ship");
            MyGameBoard.MarkShipLocation(ShipLocationP2[0], ShipLocationP2[1], "ship");
        }

        public void StartGame()
        {
            List<int> AttackLocationP1 = PlayerOne.ChooseYourTarget();
            List<int> AttackLocationP2 = PlayerTwo.ChooseYourTarget();
            MyGameBoard.MarkTileAsAttacked(AttackLocationP1[0], AttackLocationP1[1]);
            MyGameBoard.MarkTileAsAttacked(AttackLocationP2[0], AttackLocationP2[1]);
        }
        /*

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
