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
        public GameBoard MyGameBoard;
        public List<string> ShipList;        
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
        public List<int> DingyLocation;
        public List<int> DestroyerLocation;
        public List<int> SubmarineLocation;
        public List<int> BattleshipLocation;
        public List<int> AircraftCarrierLocation;
        public List<int> AttackLocation;



        //Constructor
        public Player()
        {
            ShipList = new List<string>() { "destroyer", "submarine", "battleship", "aircraftcarrier"};
            WinCount = 0;
            TotalHits = 0;
            TotalMisses = 0;
            ShipsRemaining = 4;
            EnemyShipsSunk = 0;
            MyGameBoard = new GameBoard();

        }
        //Can do this
        public virtual void PlaceYourShips()
        {
            
        }
        public virtual List<int> PlaceYourDingy(string Player)
        {
            return  new List<int> { };
        }

        public virtual void MarkShipLocation(int x, int y)
        {

        }

        public virtual List<int> ChooseYourTarget()
        {
            return new List<int> { };
        }

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

        

    }
}
