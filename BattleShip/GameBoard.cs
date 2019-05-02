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
        double[,] GridSize;
        public int HeightInput;
        public int WidthInput;

        //Constructor
        public GameBoard()
        {
            GridSize = new double[HeightInput, WidthInput];
        }        
        //does this
        public void UsersChoiceOfSize(string height, string width)
        {
            
            HeightInput = int.Parse(height);
            WidthInput = int.Parse(width);

        }
    }
}
