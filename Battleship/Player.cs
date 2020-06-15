using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Player
    {
        //member variables
        public string playerName;

        //constructor
        public Player()
        {
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
            Console.ReadLine();
            //We will return this value and use it in comparison with other player's defending array (will this go in gameplay class?)
        }
    }
}
