using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Human : Player
    {
        //Does have


        //Constructor
        public Human()
        {


        }

        //Can do this
        public override void ChooseYourCoordinates(string Player)
        {
            foreach (string ship in ShipList)
            {
                Console.WriteLine($"{Player}, What starting x coordinate would you like to choose for your {ship}?  It has a length of {ShipList.IndexOf(ship)}");
                xToStart = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Player}, What starting y coordinate would you like to choose for your {ship}?  It has a length of {ShipList.IndexOf(ship)}");
                yToStart = int.Parse(Console.ReadLine());
                if (ShipList.IndexOf(ship) > 0)
                {
                    Console.WriteLine($"{Player}, Would you like the rest of your {ship} length to be placed vertically (up or down) or horizonatally (left or right)?");
                    VertOrHori = Console.ReadLine();
                    if (VertOrHori == "vertically" || VertOrHori == "up")
                    {
                        Placement = 1;
                        xToEnd = xToStart;
                        yToEnd = yToStart - ShipList.IndexOf(ship);
                    }
                    else if (VertOrHori == "horizontally" || VertOrHori == "right")
                    {
                        Placement = 2;
                        yToEnd = yToStart;
                        xToEnd = xToStart + ShipList.IndexOf(ship);
                    }
                    else if (VertOrHori == "down")
                    {
                        Placement = 3;
                        xToEnd = xToStart;
                        yToEnd = yToStart + ShipList.IndexOf(ship);
                    }
                    else if (VertOrHori == "left")
                    {
                        Placement = 4;
                        yToEnd = yToStart;
                        xToEnd = xToStart - ShipList.IndexOf(ship);
                    }
                    else
                    {
                        //check validation and retry
                    }
                }
                switch (ship)
                {
                    case "dingy":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd, ShipList.IndexOf(ship), Placement };
                        break;
                    case "destroyer":
                        DestroyerLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd, ShipList.IndexOf(ship), Placement };
                        break;
                    case "submarine":
                        SubmarineLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd, ShipList.IndexOf(ship), Placement };
                        break;
                    case "battleship":
                        BattleshipLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd, ShipList.IndexOf(ship), Placement };
                        break;
                    case "aircraftcarrier":
                        AircraftCarrierLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd, ShipList.IndexOf(ship), Placement };
                        break;
                }
            }
        }

        public override void ChooseYourTarget(string Player)
        {
            Console.WriteLine($"{Player}, which coordinates would you like to attack? ( x )");
            xToAttack = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Player}, which coordinates would you like to attack? ( y )");
            yToAttack = int.Parse(Console.ReadLine());
            AttackLocation = new List<int> { xToAttack, yToAttack };
        }
    }
}
