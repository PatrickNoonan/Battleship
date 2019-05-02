using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    abstract class Ship
    {
        //Does have
        public double HitsTaken;
        public double ShipSize;
        public double PlacementOnGrid;

        //Ship Yard
        public Ship()
        {
            HitsTaken = 0;
        }

        //Can do this

        public void ThisShipWasHit()
        {
            HitsTaken++;
            //if HitsTaken = ShipSize "You sunk my whatever"
        }

    }
}
