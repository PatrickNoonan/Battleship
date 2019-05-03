using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    abstract class GridSquares
    {
        //Does have
        
        public bool ShipIsOn;
        public bool HasBeenAttacked;
        public bool WasHit;
        public bool WasMiss;
        public string ShipKind;
        public string GridDisplay;

        //Constructor
        public GridSquares()
        {            
            ShipIsOn = false;
            HasBeenAttacked = false;
            WasHit = false;
            WasMiss = false;
            /*
            if (WasHit == true)
            {
                GridDisplay = "X";
            } else
            {
                GridDisplay = "O";
            }
            */
            
            switch (ShipKind)
            {
                case "dingy":
                    GridDisplay = "d";
                    break;
                case "destroyer":
                    GridDisplay = "D";
                    break;
                case "submarine":
                    GridDisplay = "S";
                    break;
                case "battleship":
                    GridDisplay = "B";
                    break;
                case "aircraftcarrier":
                    GridDisplay = "A";
                    break;
                default:
                    GridDisplay = "O";
                    break;
            }



        }
        //Can do this
        
    }
}
