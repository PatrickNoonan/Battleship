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
        public Player PlayerOne;
        public Player PlayerTwo;
        public GameBoard GameBoardP1;
        public GameBoard GameBoardP2;
        public string MatchCount;
        public double MatchCountInt;
        public double MatchHalf;
        public string PlayerOneAttackResults;
        public string PlayerTwoAttackResults;
        public string KeepPlaying;
        public string YesOrNo;

        //Constructor
        public Game()
        {
            PlayerOne = new Human();
            PlayerTwo = new Human();
            GameBoardP1 = new GameBoard();
            GameBoardP2 = new GameBoard();
        }

        //does this
        public void RunGame()
        {
            if (PlayerOne.WinCount == 0 && PlayerTwo.WinCount == 0)
            {
                EnterMainMenu();
                SetRoundsInSeries();
                SetGameBoardSize();
            }

            GameBoardP1.IstantiateCoordinates();
            GameBoardP2.IstantiateCoordinates();
            SetShips();

            while (PlayerOne.ShipsRemaining > 0 && PlayerTwo.ShipsRemaining > 0)
            {
                StartAttacks();
            }

            if (PlayerOne.WinCount > 0 || PlayerTwo.WinCount > 0)
            {
                CheckForSeriesOver(MatchCountInt);
                DisplaySeriesWinner();
            }
        }

        public void EnterMainMenu()
        {
            Console.WriteLine("Welcome to Battleship.  Would you like to play vs an AI, or vs a Human? (AI or Human)");
            string PlayerTwoAIStatus = Console.ReadLine().ToLower();

            if (PlayerTwoAIStatus == "human")
            {
                PlayerTwo = new Human();
            }
            else if (PlayerTwoAIStatus == "ai")
            {
                Console.WriteLine("This feature has not yet been implemented into the game, player two will be human.");
                Console.ReadLine();
                PlayerTwo = new Human();
            }
        }

        public void SetRoundsInSeries()
        {
            Console.WriteLine("Would you like to play 1 time or play a series to the best of 3, 5, or 7?");
            MatchCount = Console.ReadLine();
            MatchCountInt = int.Parse(MatchCount);
        }

        public void SetGameBoardSize()
        {
            GameBoardP1.UsersChoiceOfSize("PlayerOne");
            GameBoardP2.UsersChoiceOfSize("PlayerTwo");
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

        public void StartAttacks()
        {
            DisplayGameBoardPrompt("Player One");
            PlayerOne.ChooseYourTarget("Player One");
            PlayerOneAttackResults = GameBoardP2.MarkTileAsAttacked(PlayerOne.AttackLocation, "PlayerOne");
            PlayerAttackCheck(PlayerOneAttackResults, "PlayerOne");

            DisplayGameBoardPrompt("Player Two");
            PlayerTwo.ChooseYourTarget("Player Two");
            PlayerTwoAttackResults = GameBoardP1.MarkTileAsAttacked(PlayerTwo.AttackLocation, "PlayerTwo");
            PlayerAttackCheck(PlayerTwoAttackResults, "PlayerTwo");
        }

        public void PlayerAttackCheck(string Ship, string Player)
        {
            if (Player == "PlayerOne")
            {
                switch (Ship)
                {
                    case "previouslyAttacked":
                        Console.WriteLine("This tile has already been attacked!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerMissed();
                        break;
                    case "miss":
                        Console.WriteLine("You missed!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerMissed();
                        break;
                    case "dingy":
                        Console.WriteLine("You sank enemy Dingy!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerHitEnemy();
                        PlayerTwo.ThisPlayerDingyHit();
                        break;
                    case "destroyer":
                        Console.WriteLine("You hit enemy Destroyer!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerHitEnemy();
                        PlayerTwo.ThisPlayerDestroyerHit();
                        break;
                    case "submarine":
                        Console.WriteLine("You hit enemy Submarine!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerHitEnemy();
                        PlayerTwo.ThisPlayerSubmarineHit();
                        break;
                    case "battleship":
                        Console.WriteLine("You hit enemy Battleship!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerHitEnemy();
                        PlayerTwo.ThisPlayerBattleshipHit();
                        break;
                    case "aircraftcarrier":
                        Console.WriteLine("You hit enemy AircraftCarrier!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerHitEnemy();
                        PlayerTwo.ThisPlayerAircraftcarrierHit();
                        break;
                }
            }
            else
            {
                switch (Ship)
                {
                    case "previouslyAttacked":
                        Console.WriteLine("This tile has already been attacked!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerMissed();
                        break;
                    case "miss":
                        Console.WriteLine("You missed!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerMissed();
                        break;
                    case "dingy":
                        Console.WriteLine("You sank enemy Dingy!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerHitEnemy();
                        PlayerOne.ThisPlayerDingyHit();
                        break;
                    case "destroyer":
                        Console.WriteLine("You hit enemy Destroyer!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerHitEnemy();
                        PlayerOne.ThisPlayerDestroyerHit();
                        break;
                    case "submarine":
                        Console.WriteLine("You hit enemy Submarine!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerHitEnemy();
                        PlayerOne.ThisPlayerSubmarineHit();
                        break;
                    case "battleship":
                        Console.WriteLine("You hit enemy Battleship!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerHitEnemy();
                        PlayerOne.ThisPlayerBattleshipHit();
                        break;
                    case "aircraftcarrier":
                        Console.WriteLine("You hit enemy AircraftCarrier!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerHitEnemy();
                        PlayerOne.ThisPlayerAircraftcarrierHit();
                        break;
                }
            }
        }

        public void DisplayGameBoardPrompt(string Player)
        {
            if (Player == "Player One")
            {
                Console.WriteLine($"{Player}, would you like to see your current game board/stats, and enemy game board?(yes or no)");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo == "yes")
                {
                    GameBoardP1.DisplayGameBoard();
                    PlayerOne.DisplayStats("Player One");
                    Console.WriteLine("Here are your hits and misses on the enemies board");
                    GameBoardP2.DisplayPartialGameBoard();

                }
            }
            else if (Player == "Player Two")
            {
                Console.WriteLine($"{Player}, would you like to see your current game board/stats, and enemy game board?(yes or no)");
                YesOrNo = Console.ReadLine().ToLower();
                if (YesOrNo == "yes")
                {
                    GameBoardP2.DisplayGameBoard();
                    PlayerTwo.DisplayStats("Player Two");
                    Console.WriteLine("Here are your hits and misses on the enemies board");
                    GameBoardP1.DisplayPartialGameBoard();
                }
            }
        }

        public void CheckForSeriesOver(double Matches)
        {
            MatchHalf = Matches / 2;
            while (PlayerOne.WinCount < MatchHalf && PlayerTwo.WinCount < MatchHalf)
            {
                Console.WriteLine($"The win count (Best of {Matches}) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                KeepPlaying = Console.ReadLine().ToLower();
                if (KeepPlaying == "yes")
                {
                    RunGame();
                }
                else
                {
                    Console.WriteLine("Ok peace out");
                    Console.ReadLine();
                }
            }
            DisplaySeriesWinner();
        }

        public void DisplaySeriesWinner()
        {
            Console.WriteLine("The Final Score is PlayerOne: " + PlayerOne.WinCount + " to PlayerTwo: " + PlayerTwo.WinCount + " GG");
            Console.ReadLine();
        }
    }
}
