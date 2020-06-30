using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public static class UserInterface
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static int GetUserInputInt(string prompt)
        {
            Console.WriteLine(prompt);
            int userInput = Int32.Parse(Console.ReadLine());
            return userInput;
        }
        public static void DisplayMenuOptions()
        {
            Console.WriteLine("Your menu options are:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. View your defending board");
            Console.WriteLine("3. View your attacking board");
        }
        public static void InvalidSelection()
        {
            Console.WriteLine("Invalid selection detected.  Please try again.");
        }
    }
}
