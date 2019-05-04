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
        public List<int> DingyLocation;
        public List<int> SubmarineLocation;
        public List<int> DestroyerLocation;
        public List<int> BattleshipLocation;
        public List<int> AircraftCarrierLocation;
        public List<int> AttackLocation;
        public double WinCount;
        public double TotalHits;
        public double TotalMisses;
        public double ShipsRemaining;
        public int Placement;
        public int xToAttack;
        public int yToAttack;
        public int xToStart;
        public int yToStart;
        public int xToEnd;
        public int yToEnd;
        public int DingyHP;
        public int DestroyerHP;
        public int SubmarineHP;
        public int BattleshipHP;
        public int AircraftcarrierHP;
        public string VertOrHori;

        //Constructor
        public Player()
        {
            ShipList = new List<string>() { "dingy", "destroyer", "submarine", "battleship", "aircraftcarrier" };
            WinCount = 0;
            TotalHits = 0;
            TotalMisses = 0;
            ShipsRemaining = 4;
            DingyHP = 1;
            DestroyerHP = 2;
            SubmarineHP = 3;
            BattleshipHP = 4;
            AircraftcarrierHP = 5;
        }

        //Can do this
        public virtual void ChooseYourCoordinates(string Player) { }
        public virtual void ChooseYourTarget(string Player) { }

        public void ThisPlayerWon()
        {
            WinCount++;
        }

        public void ThisPlayerDingyHit()
        {
            DingyHP--;
            if (DingyHP == 0)
            {
                ThisPlayersShipWasSunk();
            }
        }
        public void ThisPlayerDestroyerHit()
        {
            DestroyerHP--;
            if (DestroyerHP == 0)
            {
                Console.WriteLine("You Sank the enemy Destroyer!");
                ThisPlayersShipWasSunk();
            }
        }
        public void ThisPlayerSubmarineHit()
        {
            SubmarineHP--;
            if (SubmarineHP == 0)
            {
                Console.WriteLine("You Sank the enemy Submarine!");
                ThisPlayersShipWasSunk();
            }
        }
        public void ThisPlayerBattleshipHit()
        {
            BattleshipHP--;
            if (BattleshipHP == 0)
            {
                Console.WriteLine("You Sank the enemy Battle Ship!");
                ThisPlayersShipWasSunk();
            }
        }
        public void ThisPlayerAircraftcarrierHit()
        {
            AircraftcarrierHP--;
            if (AircraftcarrierHP == 0)
            {
                Console.WriteLine("You Sank the enemy Aircraft Carrier!");
                ThisPlayersShipWasSunk();
            }
        }
        public void ThisPlayersShipWasSunk()
        {
            ShipsRemaining--;
            Console.WriteLine("Enemy ships remaining are " + ShipsRemaining);
            Console.ReadLine();
            if (ShipsRemaining == 0)
            {
                Console.Write("All Player ships have been sunk, Game Over");
                Console.ReadLine();
                ThisPlayerWon();
            }
        }
        public void ThisPlayerHitEnemy()
        {
            TotalHits++;
        }
        public void ThisPlayerMissed()
        {
            TotalMisses++;
        }
        public void DisplayStats(string Player)
        {
            Console.WriteLine($"{Player} has " + TotalHits + " total hits, " + TotalMisses + " total misses, and " + ShipsRemaining + " ships remaining.");
        }
    }
}
