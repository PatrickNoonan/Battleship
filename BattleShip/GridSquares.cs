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

        //Constructor
        public GridSquares()
        {            
            ShipIsOn = false;
            HasBeenAttacked = false;
            WasHit = false;
            WasMiss = false;
            ShipKind = "";

        }
        //Can do this
        
    }
}
