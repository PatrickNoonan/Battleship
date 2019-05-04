﻿using System;
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
        public double Round;
        public string YesOrNo;
        /*
        InputValidation Validate;
        Gestures2 MadeGestures;                
        string WhoWon;
        string ChoiceOne;
        string ChoiceTwo;  
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
            StartAttacks();
            
            //Checkforend of round then start code below
            if (PlayerOne.WinCount > 0 || PlayerTwo.WinCount > 0)
            {
                CheckForGameOver(MatchCountInt);
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
                PlayerTwo = new CPU();
            }
        }

        public void SetRoundsInSeries()
        {
            Console.WriteLine("Would you like to play 1 time or play a series to the best of 3, 5, or 7?");
            MatchCount = Console.ReadLine().ToLower();
            MatchCountInt = int.Parse(MatchCount);
        }

        public void SetGameBoardSize()
        {

            GameBoardP1.UsersChoiceOfSize();
            GameBoardP2.UsersChoiceOfSize();
        }


        public void SetShips()
        {
            PlayerOne.ChooseYourCoordinates("PlayerOne");
            GameBoardP1.MarkShipLocation(PlayerOne.DingyLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.DestroyerLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.SubmarineLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.BattleshipLocation);
            GameBoardP1.MarkShipLocation(PlayerOne.AircraftCarrierLocation);
            DisplayGameBoardPrompt();
            

            PlayerTwo.ChooseYourCoordinates("PlayerTwo");
            GameBoardP2.MarkShipLocation(PlayerTwo.DingyLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.DestroyerLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.SubmarineLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.BattleshipLocation);
            GameBoardP2.MarkShipLocation(PlayerTwo.AircraftCarrierLocation);
            DisplayGameBoardPrompt();
        }

        public void StartAttacks()
        {
            PlayerOne.ChooseYourTarget();
            PlayerOneAttackResults = GameBoardP2.MarkTileAsAttacked(PlayerOne.AttackLocation, "PlayerOne");
            PlayerAttackCheck(PlayerOneAttackResults, "PlayerOne");
            DisplayGameBoardPrompt();


            PlayerTwo.ChooseYourTarget();
            PlayerTwoAttackResults = GameBoardP1.MarkTileAsAttacked(PlayerTwo.AttackLocation, "PlayerTwo");
            PlayerAttackCheck(PlayerTwoAttackResults, "PlayerTwo");
            DisplayGameBoardPrompt();

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
                        Console.WriteLine("You sunk my Dingy!.. jerk");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerDingyHit();
                        break;
                    case "destroyer":
                        Console.WriteLine("You hit enemy Destroyer!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerDestroyerHit();
                        break;
                    case "submarine":
                        Console.WriteLine("You hit enemy Submarine!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerSubmarineHit();
                        break;
                    case "battleship":
                        Console.WriteLine("You hit enemy Battleship!");
                        Console.ReadLine();
                        PlayerTwo.ThisPlayerBattleshipHit();
                        break;
                    case "aircraftcarrier":
                        Console.WriteLine("You hit enemy AircraftCarrier!");
                        Console.ReadLine();
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
                        Console.WriteLine("You sunk my Dingy!.. jerk");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerDingyHit();
                        break;
                    case "destroyer":
                        Console.WriteLine("You hit enemy Destroyer!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerDestroyerHit();
                        break;
                    case "submarine":
                        Console.WriteLine("You hit enemy Submarine!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerSubmarineHit();
                        break;
                    case "battleship":
                        Console.WriteLine("You hit enemy Battleship!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerBattleshipHit();
                        break;
                    case "aircraftcarrier":
                        Console.WriteLine("You hit enemy AircraftCarrier!");
                        Console.ReadLine();
                        PlayerOne.ThisPlayerAircraftcarrierHit();
                        break;
                }
            }
        }

        public void DisplayGameBoardPrompt()
        {
            Console.WriteLine("Would you like to see PlayerOnes game board and stats?(yes or no)");
            YesOrNo = Console.ReadLine();
                if ( YesOrNo == "yes")
                {
                    GameBoardP1.DisplayGameBoard();
                }

            Console.WriteLine("Would you like to see PlayerTwos game board and stats?(yes or no)");
            YesOrNo = Console.ReadLine();
                if (YesOrNo == "yes")
                {
                    GameBoardP2.DisplayGameBoard();
                }
        }

        public void CheckForGameOver(double Matches)
        {
            MatchHalf = Matches / 2;
            while (PlayerOne.WinCount < MatchHalf && PlayerTwo.WinCount < MatchHalf)
            {
                Console.WriteLine($"The win count (Best of {Matches}) is " + PlayerOne.WinCount + " to " + PlayerTwo.WinCount + "... Keep Playing?");
                KeepPlaying = Console.ReadLine().ToLower();
                //Validate.IsItValid(KeepPlaying);
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
