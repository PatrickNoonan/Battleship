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
        Coordinate[,] GameGrid;
        public int WidthInput;
        public int HeightInput;

        //Constructor
        public GameBoard()
        {
            GameGrid = new Coordinate[WidthInput, HeightInput];
            
        }        
        //does this
        public void UsersChoiceOfSize()
        {
            Console.WriteLine("What size would you like the gameboard to be? (Equal height and width between 20 and 30)");
            WidthInput = int.Parse(Console.ReadLine());
            HeightInput = int.Parse(Console.ReadLine());

            //PlayerTwo.RandomNumber(WidthInput);
        }

        public void IstantiateCoordinates()
        {
            for (int y = 0; y < HeightInput; y++)
            {
                for (int x = 0; x < WidthInput; x++)
                {
                    GameGrid[x, y] = new Coordinate(x, y);
                }
            }
        }
    }
}
