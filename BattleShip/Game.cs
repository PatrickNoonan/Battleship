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
        public Player PlayerTwo;
        public Player PlayerOne;        
        public GameBoard GameBoardP1;
        public GameBoard GameBoardP2;
        public string MatchCount;
        public double MatchCountInt;
        public double MatchHalf;
        /*InputValidation Validate;
        Gestures2 MadeGestures;        
        string KeepPlaying;
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;        
        double round;
        double[] GridSize;
        */

        //Constructor
        public Game()
        {
            /*
            Validate = new InputValidation();            
            MadeGestures = new Gestures2();
            round = 0;
            */
            PlayerOne = new Human();
            GameBoardP1 = new GameBoard();
            GameBoardP2 = new GameBoard();

        }

        //does this
        public void RunGame()
        {
            //if (round == 0)
            //{
            EnterMainMenu();
            //}
            GameBoardP1.IstantiateCoordinates();
            GameBoardP2.IstantiateCoordinates();
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
            GameBoardP1.UsersChoiceOfSize();
            GameBoardP2.UsersChoiceOfSize();


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
            PlayerOne.ChooseYourCoordinates("PlayerOne");
            GameBoardP1.MarkShipLocation(PlayerOne.DingyLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.DestroyerLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.SubmarineLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.BattleshipLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.AircraftCarrierLocation);

            PlayerTwo.ChooseYourCoordinates("PlayerTwo");
            GameBoardP2.MarkShipLocation(PlayerTwo.DingyLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.DestroyerLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.SubmarineLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.BattleshipLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.AircraftCarrierLocation);
        }

        public void StartGame()
        {
            PlayerOne.ChooseYourTarget();
            GameBoardP2.MarkTileAsAttacked(PlayerOne.AttackLocation, "PlayerOne");

            PlayerTwo.ChooseYourTarget();
            GameBoardP1.MarkTileAsAttacked(PlayerTwo.AttackLocation, "PlayerTwo");

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
