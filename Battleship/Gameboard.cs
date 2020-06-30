using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    class Gameboard
    {
        //member variables
        string[,] gameArray;
        string[] alphabetArray = new string[27] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        //constructor
        public Gameboard()
        {
            gameArray = new string[21, 21];
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameArray.GetLength(0); j++)
                {
                    gameArray[i, j] = "O";
                }
            }
            for (int i = 0; i < 21; i++)
            {
                gameArray[0, i] = alphabetArray[i];
            }
            
            for (int j = 0; j < 21; j++)
            {
                gameArray[j, 0] = j.ToString();
            }
            
            //We can compare one player"s attackArray with another"s defenseArray
        }
        //member methods
        public void DisplayGameboard()
        {
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameArray.GetLength(1); j++)
                {//Using GetLength to get the length of an inner array (in attackArray) at index 0/1/etc)
                    if (i < 10 && j == 0)
                    {
                        Console.Write(gameArray[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(gameArray[i, j] + " ");
                        //We use Write instead of WriteLine so each index does not break a line
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
