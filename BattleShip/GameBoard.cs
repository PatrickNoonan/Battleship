using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoard
    {
        //has these
        public int SizeInput;
        public Coordinate[,] GameSquare;
        public List<string> ShipList;


        //Constructor
        public GameBoard()
        {

        }        


        //does this
        public void UsersChoiceOfSize()
        {
            Console.WriteLine("What size would you like the gameboard to be? (between 20 and 30)");
            SizeInput = int.Parse(Console.ReadLine());
            ShipList = new List<string>() { "dingy", "destroyer", "submarine", "battleship", "aircraftcarrier" };

            //PlayerTwo.RandomNumber(WidthInput);
        }

        public void IstantiateCoordinates()
        {
            GameSquare = new Coordinate[SizeInput, SizeInput];
            for (int y = 0; y < SizeInput; y++)
            {
                for (int x = 0; x < SizeInput; x++)
                {
                    GameSquare[x, y] = new Coordinate();
                }
            }                   
        }

        public void MarkShipLocation(List<int> ShipLocationList)
        {
            string ShipType = ShipList[ShipLocationList[4] - 1];
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipIsOn = true;
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipKind = ShipType;
        }

        public void MarkTileAsAttacked(List<int> TargetedTile, string Player)
        {
            // GameSquare[TargetedTile[0], TargetedTile[0]].HasBeenAttacked = true;
            //if a gamesquare has been attacked is should show an error if targeted again
            //console.log for user to try a different input
            if (Player == "PlayerOne")
            {

                if (GameSquare[TargetedTile[0], TargetedTile[1]].ShipIsOn == true)
                {
                    GameSquare[TargetedTile[0], TargetedTile[1]].WasHit = true;
                    //PlayerOne.ThisPlayerHit();

                    switch (GameSquare[TargetedTile[0], TargetedTile[1]].ShipKind)
                    {
                        case "dingy":
                            Console.WriteLine("You sunk my Dingy!.. jerk");
                            Console.ReadLine();
                            break;
                        case "destroyer":
                            Console.WriteLine("You hit enemy Destroyer!");
                            Console.ReadLine();
                            break;
                        case "submarine":
                            Console.WriteLine("You hit enemy Submarine!");
                            Console.ReadLine();
                            break;
                        case "battleship":
                            Console.WriteLine("You hit enemy Battleship!");
                            Console.ReadLine();
                            break;
                        case "aircraftcarrier":
                            Console.WriteLine("You hit enemy AircraftCarrier!");
                            Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    GameSquare[TargetedTile[0], TargetedTile[1]].WasMiss = true;
                    //PlayerOne.ThisPlayerMissed();
                }
            } else 
            {

                if (GameSquare[TargetedTile[0], TargetedTile[1]].ShipIsOn == true)
                {
                    GameSquare[TargetedTile[0], TargetedTile[1]].WasHit = true;
                    
                    switch (GameSquare[TargetedTile[0], TargetedTile[1]].ShipKind)
                    {
                        case "dingy":
                            Console.WriteLine("You sunk my Dingy!.. jerk");
                            Console.ReadLine();
                            break;
                        case "destroyer":
                            //PlayerTwo.ThisPlayerHitDestroyer();
                            Console.WriteLine("You hit enemy Destroyer!");
                            Console.ReadLine();
                            break;
                        case "submarine":
                            Console.WriteLine("You hit enemy Submarine!");
                            Console.ReadLine();
                            break;
                        case "battleship":
                            Console.WriteLine("You hit enemy Battleship!");
                            Console.ReadLine();
                            break;
                        case "aircraftcarrier":
                            Console.WriteLine("You hit enemy AircraftCarrier!");
                            Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    GameSquare[TargetedTile[0], TargetedTile[1]].WasMiss = true;
                    //PlayerTwo.ThisPlayerMissed();
                }
            }


        }
    }
}
