using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Human : Player
    {
        //HumanPlayer is redundant
        //Does have
        

        //Constructor
        public Human()
        {


        }
        //Can do this

        public override void PlaceYourShip(string Player)
        {
            foreach (string ship in ShipList)
            {
                Console.WriteLine($"{Player}, What starting x coordinate would you like to choose for your {ship}?");
                xToStart = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Player}, What starting y coordinate would you like to choose for your {ship}?");
                yToStart = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Player}, What ending coordinate would you like to choose for your {ship}?  It has a length of {ShipList.IndexOf(ship + 1)}");
                xToEnd = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Player}, What ending coordinate would you like to choose for your {ship}?  It has a length of {ShipList.IndexOf(ship + 1)}");
                yToEnd = int.Parse(Console.ReadLine());
                
                switch (ship)
                {
                    case "dingy":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
                        break;
                    case "destroyer":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
                        break;
                    case "submarine":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
                        break;
                    case "battleship":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
                        break;
                    case "aircraftcarrier":
                        DingyLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
                        break;
                }

            }
        }
                
        public override List<int> ChooseYourTarget()
        {
            Console.WriteLine("Which coordinates would you like to attack? ( x )");
            xToAttack = int.Parse(Console.ReadLine());
            Console.WriteLine("Which coordinates would you like to attack? ( y )");
            yToAttack = int.Parse(Console.ReadLine());
            AttackLocation = new List<int> { xToAttack, yToAttack };
            return AttackLocation;

        }
    }
}
