using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class RulesAndLogic
    {
        /*
         * 
         * 2 Player Battleship
    Using a two-dimensional array, create a battleship game board (minimum space size of 20x20) for each player. 
    --instantiate a game board map consisting of two arrays of at least20 indeces, each
    --use nested loop https://www.youtube.com/watch?v=0mMI__LFJDc
    --array of objects that hold squares hit or not hit bool?
    --can player choose game grid size?
    --class GameGrid ThisGrid = new GameGrid();
    --create a parent player class with a human subclass that can be instantiated into playerone and playertwo

    Allow the player to place a destroyer (space size: 2), submarine (space size: 3), battleship 
    (space size: 4, and aircraft carrier (space size: 5) on the game board. Check to make sure that they do not overlap. 
    --Create a parents class that has a shipyard/ship spawner/ship constructor, inside the parent class you will have
    -- the traits all ships will have, but you will have subclasses for specific ships with their specific sizes
    
    Ensure that each player can place their ships on the game board and that the ship locations will be hidden from the other player. 
    (You can assume that each player will move away from the screen when it is not their turn). 
    --make a class that allows each player, one at a time, to place their pieces on the game board.
    --this could possibly be a member method inside the indiviual player class or part of a start game menu, or maybe seperate class

    On each player turn they should be presented with a console print out of the other player’s board as they know it. 
    (Ships and parts of ships that haven’t been hit should be hidden, misses should be displayed. 
    Each player should also be able to view their own board with updated hits and misses).
    --Create a turn based system where the player gets to choose which square of the grid to attack, after the attack happens,
    --display all squares on the grid that have been attacked up to this point, displayed as hits and misses.
    --if the player desires, he should be able to display which squares on his own grid side have been hit or missed up to this point
    
    
    The game should keep track of which ships have been completely destroyed. This is a way to keep score.
    --option to check which ships have been completely destroyed

    2 Player Battleship
    (20 points) As a developer, I want to create a two-player Battleship game that follows the standard Battleship rules, 
    --so that two players can enjoy the turn-base game.
    (20 points) As a developer, I want to use a two-dimensional array to create a game board with a minimum space size of 20x20 
    --for each player. 
    (15 points) As a developer, I want a player to place a destroyer (space size: 2), submarine (space size: 3), 
    --battleship (space size: 4), and aircraft carrier (space size: 5) on the game board, and ensure the ships do not overlap, 
    --so that players have the ability to move their ships around as desired. 
    (15 points) As a developer, I want each player to have their ship locations hidden from the other player, 
    --so that the game is played fairly.
    (10 points) As a developer, I want to present each player, on their turn, with a console print-out of the other player’s 
    --board as they know it, so that a player can see his or her hits and misses. 
    (10 points) As a developer, I want to present each player, on their turn, with a console print-out of his or her own 
    --board with updated hits and misses.
    (10 points) As a player, I want the game to keep track of which ships I have completely destroyed, 
    --so that I can keep score of who is winning. 

    SOLID~~~
  S Single responsibility principle
    -A class should have only a single responsibility, that is, only changes to one part of the software's specification 
    -should be able to affect the specification of the class.
  O Open–closed principle
    -"Software entities ... should be open for extension, but closed for modification."
  L Liskov substitution principle
    -"Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." 
    --See also design by contract.
  I Interface segregation principle
    -"Many client-specific interfaces are better than one general-purpose interface."
  D Dependency inversion principle[
    -One should "depend upon abstractions, [not] concretions."






    */
    }
}
