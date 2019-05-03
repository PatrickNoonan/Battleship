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
        public List<string> ShipList = new List<string>() { "dingy", "destroyer", "submarine", "battleship", "aircraftcarrier" };


        //Constructor
        public GameBoard()
        {

        }


        //does this
        public void UsersChoiceOfSize()
        {
            Console.WriteLine("What size would you like the gameboard to be? (between 20 and 30)");
            SizeInput = int.Parse(Console.ReadLine());
            
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

        public void DisplayGameBoard()
        {

        }

        public void MarkShipLocation(List<int> ShipLocationList)
        {
            string ShipType = ShipList[ShipLocationList[4]];
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipIsOn = true;
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipKind = ShipType;
        }

        public string MarkTileAsAttacked(List<int> TargetedTile, string Player)
        {
            if (GameSquare[TargetedTile[0], TargetedTile[0]].HasBeenAttacked == true)
            {
                return "previouslyAttacked";
            }
            else
            {

                if (Player == "PlayerOne")
                {
                    if (GameSquare[TargetedTile[0], TargetedTile[1]].ShipIsOn == true)
                    {
                        GameSquare[TargetedTile[0], TargetedTile[1]].WasHit = true;
                        return GameSquare[TargetedTile[0], TargetedTile[1]].ShipKind;

                    }
                    else
                    {
                        GameSquare[TargetedTile[0], TargetedTile[1]].WasMiss = true;
                        return "miss";
                    }
                }
                else
                {

                    if (GameSquare[TargetedTile[0], TargetedTile[1]].ShipIsOn == true)
                    {
                        GameSquare[TargetedTile[0], TargetedTile[1]].WasHit = true;
                        return GameSquare[TargetedTile[0], TargetedTile[1]].ShipKind;
                    }
                    else
                    {
                        GameSquare[TargetedTile[0], TargetedTile[1]].WasMiss = true;
                        return "miss";
                    }
                }
            }

        }
    }
}
