﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Gameplay
    {
        //member variables
        public Player playerOne;
        public Player playerTwo;
        public bool playerOneWins;

        //constructor
        public Gameplay()
        {
            playerOne = new Player();
            playerTwo = new Player();

        }
        //method
        public void DisplayGameRules()
        {
            Console.WriteLine("Battleship is a 2-player game of strategy.  Both players will hide a Destroyer (X X), a Submarine (X X X), a Battleship (X X X X), and an Aircraft Carrier(X X X X X) in their DEFENDING ARRAY.");
            Console.WriteLine("Then, players will take turns selecting coordinates to attack their ATTACKING ARRAY, which will return either a HIT (X) or a MISS (O)");
            Console.WriteLine("Once all spots on a ship have been hit, that ship has sunk.  The game continues until all of a player's ships have been sunk");
            Console.WriteLine("When you are ready, press any key to continue.");
        }

        public void DisplayGameWinner()
        {
            if (playerOneWins)
            {
                Console.WriteLine($"Congratulations {playerOne.playerName}!  You win!!");
            }
            else
            {
                Console.WriteLine($"Congratulations {playerTwo.playerName}!  You win!!");
            }
        }

        //1. Welcome message & display rules
        //2. Create "player profiles"
            //We'll assign them a name and give them a chance to place their ships
            //Distroyer: X X
            //Submarine: X X X 
            //Battleship X X X X 
            //Aircraft Carrier X X X X X
            //SHIPS CANNOT OVERLAP (Will need if statement for this)

        //Each player can have 2 arrays for gameplay - "Defending" and "Attacking"
            //Same size (20 X 20)
            //With each turn we can display the "Defending" and "Attacking" arrays 
                    //Should we use a menu selection for this?
        //Players alternate attacking each other
            //Will provide input as a coordinate (One will be index in first array, second will be index in second array)
                //We will return a response for a HIT or a MISS
                    
                //Will also have a response for SINKING A SHIP
                //Continues until all ships have been sunk
                //Will then display winner message
    }
}
