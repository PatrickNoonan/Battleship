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
        public void UsersChoiceOfSize(string Player)
        {
            Console.WriteLine($"{Player}, what size would you like your gameboard to be?");
            SizeInput = int.Parse(Console.ReadLine());
        }

        public void IstantiateCoordinates()
        {
            GameSquare = new Coordinate[SizeInput, SizeInput];
            for (int x = 0; x < SizeInput; x++)
            {
                for (int y = 0; y < SizeInput; y++)
                {
                    GameSquare[y, x] = new Coordinate();
                }
            }
        }

        public void DisplayGameBoard()
        {
            for (int x = 0; x < SizeInput; x++)
            {
                for (int y = 0; y < SizeInput; y++)
                {
                    GameSquare[y, x].ChangeDisplay();
                    Console.Write(GameSquare[y, x].GridDisplay + "  ");
                }
                Console.WriteLine();
            }            
        }
        public void DisplayPartialGameBoard()
        {
            for (int x = 0; x < SizeInput; x++)
            {
                for (int y = 0; y < SizeInput; y++)
                {
                    GameSquare[y, x].ChangeDisplay();
                    Console.Write(GameSquare[y, x].PartialDisplay + "  ");
                }
                Console.WriteLine();
            }
        }

        public void MarkShipLocation(List<int> ShipLocationList)
        {
            string ShipType = ShipList[ShipLocationList[4]];
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipIsOn = true;
            GameSquare[ShipLocationList[0], ShipLocationList[1]].ShipKind = ShipType;
            switch (ShipLocationList[5])
            {
                case 1:
                    for (int i = ShipLocationList[1]; i >= ShipLocationList[3]; i--)
                    {
                        GameSquare[ShipLocationList[0], i].ShipIsOn = true;
                        GameSquare[ShipLocationList[0], i].ShipKind = ShipType;
                    }
                    break;
                case 2:
                    for (int i = ShipLocationList[0]; i <= ShipLocationList[2]; i++)
                    {
                        GameSquare[i, ShipLocationList[1]].ShipIsOn = true;
                        GameSquare[i, ShipLocationList[1]].ShipKind = ShipType;
                    }
                    break;
                case 3:
                    for (int i = ShipLocationList[1]; i <= ShipLocationList[3]; i++)
                    {
                        GameSquare[ShipLocationList[0], i].ShipIsOn = true;
                        GameSquare[ShipLocationList[0], i].ShipKind = ShipType;
                    }
                    break;
                case 4:
                    for (int i = ShipLocationList[0]; i >= ShipLocationList[2]; i--)
                    {
                        GameSquare[i, ShipLocationList[1]].ShipIsOn = true;
                        GameSquare[i, ShipLocationList[1]].ShipKind = ShipType;
                    }
                    break;                                        
            }
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
