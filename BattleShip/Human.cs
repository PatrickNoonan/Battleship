﻿using System;
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
        public override void PlaceYourShips()
        {
            //console log (where would you like to place your destroyer?, x and y)
            PlaceYourDingy();
            /*
            PlaceYourDestroyer();
            PlaceYourSubmarine();
            PlaceYourBattleship();
            PlaceYourAircraftcarrier();
            */
        }

        public void PlaceYourDingy()
        {
            Console.WriteLine("What starting x coordinate would you like to choose?");
            xToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What starting y coordinate would you like to choose?");
            yToStart = int.Parse(Console.ReadLine());
            DingyLocation = new List<int> { xToStart, yToStart };
            MyGameBoard.MarkShipLocation(DingyLocation[0], DingyLocation[1]);
        }
        public void PlaceYourDestroyer()
        {
            Console.WriteLine("What starting x coordinate would you like to choose?");
            xToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What starting y coorinate would you like to choose?");
            yToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending x coordinate would you like to choose?(Can be 2 more or less than start, must keep starting input of other axis)");
            xToEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending y coorinate would you like to choose?(Can be 2 more of less than start, must keep starting input of other axis)");
            yToEnd = int.Parse(Console.ReadLine());
            DestroyerLocation = new List<int>{ xToStart, yToStart, xToEnd, yToEnd };
        }
        public void PlaceYourSubmarine()
        {
            Console.WriteLine("What starting x coordinate would you like to choose?");
            xToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What starting y coorinate would you like to choose?");
            yToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending x coordinate would you like to choose?(Can be 3 more or less than start, must keep starting input of other axis)");
            xToEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending y coorinate would you like to choose?(Can be 3 more of less than start, must keep starting input of other axis)");
            yToEnd = int.Parse(Console.ReadLine());
            SubmarineLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
        }
        public void PlaceYourBattleship()
        {
            Console.WriteLine("What starting x coordinate would you like to choose?");
            xToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What starting y coorinate would you like to choose?");
            yToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending x coordinate would you like to choose?(Can be 4 more or less than start, must keep starting input of other axis)");
            xToEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending y coorinate would you like to choose?(Can be 4 more of less than start, must keep starting input of other axis)");
            yToEnd = int.Parse(Console.ReadLine());
            BattleshipLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
        }
        public void PlaceYourAircraftcarrier()
        {
            Console.WriteLine("What starting x coordinate would you like to choose?");
            xToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What starting y coorinate would you like to choose?");
            yToStart = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending x coordinate would you like to choose?(Can be 5 more or less than start, must keep starting input of other axis)");
            xToEnd = int.Parse(Console.ReadLine());
            Console.WriteLine("What ending y coorinate would you like to choose?(Can be 5 more of less than start, must keep starting input of other axis)");
            yToEnd = int.Parse(Console.ReadLine());
            AircraftCarrierLocation = new List<int> { xToStart, yToStart, xToEnd, yToEnd };
        }
        
        
        public override void ChooseYourTarget()
        {
            Console.WriteLine("Which coordinates would you like to attack? ( x )");
            xToAttack = int.Parse(Console.ReadLine());
            Console.WriteLine("Which coordinates would you like to attack? ( y )");
            yToAttack = int.Parse(Console.ReadLine());
            //Validate.IsItValid(GestureChoice);            
        }
    }
}
