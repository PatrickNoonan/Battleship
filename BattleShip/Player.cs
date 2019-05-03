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
        //public InputValidation Validate;
        //public GameBoard MyGameBoard;
        public List<string> ShipList;
        public List<int> ShipLocation;
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
        public double EnemyShipsSunk;
        public string ShipType;
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




        //Constructor
        public Player()
        {
            ShipList = new List<string>() { "dingy", "destroyer", "submarine", "battleship", "aircraftcarrier"};
            WinCount = 0;
            TotalHits = 0;
            TotalMisses = 0;
            ShipsRemaining = 4;
            EnemyShipsSunk = 0;
            DingyHP = 1;
            DestroyerHP = 2;
            SubmarineHP = 3;
            BattleshipHP = 4;
            AircraftcarrierHP = 5;

        //MyGameBoard = new GameBoard();

        }
        //Can do this
        public virtual void ChooseYourCoordinates(string Player)
        {

        }

        public virtual List<int> PlaceYourShip(string Player)
        {
            return new List<int> { };
        }

        public virtual void MarkShipLocation(int x, int y)
        {

        }

        public virtual void ChooseYourTarget()
        {
        }

        public void ThisPlayerWon()
        {
            WinCount++;
        }

        public void ThisPlayerHitDingy()
        {
            TotalHits++;
            DingyHP--;
            if (DingyHP == 0)
            {
                ThisPlayersShipWasSunk();
            }

        }

        public void ThisPlayerHitDestroyer()
        {
            TotalHits++;
            DestroyerHP--;
            if (DestroyerHP == 0)
            {
                ThisPlayersShipWasSunk();
            }

        }
        public void ThisPlayerHitSubmarine()
        {
            TotalHits++;
            SubmarineHP--;
            if (SubmarineHP == 0)
            {
                ThisPlayersShipWasSunk();
            }

        }
        public void ThisPlayerHitBattleship()
        {
            TotalHits++;
            BattleshipHP--;
            if (BattleshipHP == 0)
            {
                ThisPlayersShipWasSunk();
            }

        }
        public void ThisPlayerHitAircraftcarrier()
        {
            TotalHits++;
            AircraftcarrierHP--;
            if (AircraftcarrierHP == 0)
            {
                ThisPlayersShipWasSunk();
            }

        }
        public void ThisPlayersShipWasSunk()
        {
            ShipsRemaining--;
            Console.WriteLine("ShipsRemaining");
            Console.ReadLine();
            if (ShipsRemaining == 0)
            {
                Console.Write("All Player ships have been sunk, Game Over");
                Console.ReadLine();
            }
        }

        public void ThisPlayerMissed()
        {
            TotalMisses++;
        }


        

    }
}
