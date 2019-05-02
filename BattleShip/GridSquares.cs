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
        public bool WasMissed;
        public string ShipKind;

        //Constructor
        public GridSquares()
        {            
            ShipIsOn = false;
            HasBeenAttacked = false;
            WasHit = false;
            WasMissed = false;
            ShipKind = "";

        }
        //Can do this
        
    }
}
