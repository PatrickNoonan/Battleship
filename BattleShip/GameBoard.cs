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
            for (int y = 0; y <= SizeInput; y++)
            {
                for (int x = 0; x <= SizeInput; x++)
                {
                    GameSquare[x, y] = new Coordinate();
                }
            }                   
        }
        public void MarkShipLocation(int x, int y)
        {
            GameSquare[x, y].ShipIsOn = true;
        }
    }
}
