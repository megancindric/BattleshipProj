using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Gameboard
    {
        //member variables
        string[,] attackArray;
        string[] alphabetArray = new string[27] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        //constructor
        public Gameboard()
        {
            //Before setting letters & numbers on rows/columns let's set every value to O
            attackArray = new string[21, 21];
            for (int i = 0; i < attackArray.GetLength(0); i++)
            {
                for (int j = 0; j < attackArray.GetLength(0); j++)
                {
                    attackArray[i, j] = "O";
                }
            }
            for (int i = 0; i < 21; i++)
            {
                attackArray[0, i] = alphabetArray[i];
            }
            
            for (int j = 0; j < 21; j++)
            {
                attackArray[j, 0] = j.ToString();
            }
            
            //could we use a for loop here (for (i = 0, i < attackArray.length, i++) {attackArray[i] = [A, B, C....etc.]
            //how can we use iteration to assign LETTERS to one of these values?
            //Will also have DEFENSEARRAY that will hold values (Maybe an X?) for every ship they place
            //We can compare one player"s attackArray with another"s defenseArray
        }
        //member methods
        public void DisplayGameboard()
        {
            for (int i = 0; i < attackArray.GetLength(0); i++)
            {
                for (int j = 0; j < attackArray.GetLength(1); j++)
                {//Using GetLength to get the length of an inner array (in attackArray) at index 0/1/etc)
                    Console.Write(attackArray[i, j]);
                    //We use Write instead of WriteLine so each index does not break a line
                }
                Console.WriteLine();
            }
        }
    }
}
