using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Player
    {
        //member variables
        public string playerName;
        public Gameboard attackingBoard;
        public Gameboard defendingBoard;

        //constructor
        public Player()
        {
            attackingBoard = new Gameboard();
            defendingBoard = new Gameboard();
            playerName = SelectPlayerName();
            
        }

        //member methods
        public string SelectPlayerName()
        {
            Console.WriteLine("Please enter Player's name.");
            return Console.ReadLine();
            
        }

        public void BattleshipAttack()
        {
            Console.WriteLine($"{playerName}, where would you like to attack?");
            //^will move this to user interface
            Console.ReadLine();
            //We will return this value and use it in comparison with other player's defending array (will this go in gameplay class?)
        }
        public void PlaceShip()
        {
            //Will prompt user to select a starting location coordinate
            //can then receive input on which direction they would like to place (Up, down, left, right)
            //Will check to see if all spots are of type VOID
        }
    }
}
