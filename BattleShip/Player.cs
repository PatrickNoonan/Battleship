using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    abstract class Player
    {
        //Does have
        public List<string> ShipList;
        //public InputValidation Validate;
        public double WinCount;
        public double TotalHits;
        public double TotalMisses;
        public double ShipsRemaining;
        public double EnemyShipsSunk;
        public string ShipType;
        

        //Constructor
        public Player()
        {
            ShipList = new List<string>() { "destroyer", "submarine", "battleship", "aircraftcarrier"};
            WinCount = 0;
            TotalHits = 0;
            TotalMisses = 0;
            ShipsRemaining = 4;
            EnemyShipsSunk = 0;

        }
        //Can do this

        public void ThisPlayerWon()
        {
            WinCount++;
        }

        public void ThisPlayerHitSomething()
        {
            TotalHits++;
        }

        public void ThisPlayerMissedSomething()
        {
            TotalMisses++;
        }

        public void ThisPlayersShipWasSunk()
        {
            ShipsRemaining--;
        }

        public void ThisPlayerSunkAnEnemyShip()
        {
            //Console.WriteLine($"You sunk an enemy {ShipType}")
            EnemyShipsSunk++;
        }

        public virtual string ChooseYourTarget()
        {
            return "";
        }

    }
}
