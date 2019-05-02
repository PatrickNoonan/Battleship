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
        
        bool ShipIsOn;
        bool HasBeenAttacked;
        bool WasHit;
        bool WasMissed;


        //Constructor
        public GridSquares()
        {            
            ShipIsOn = false;
            HasBeenAttacked = false;
            WasHit = false;
            WasMissed = false;

        }
        //Can do this

        
    }
}
