using System;

namespace RpsGame_NoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool userResponseInt;
            do
            {
                Console.WriteLine("This is The Official Rock, Paper, Scissors Game");
                Console.WriteLine("Please chose by inputting a number and hitting enter");
                Console.WriteLine("\t 1. Rock \n\t 2. Paper \n\t 3.Scissors");
                string userResponse = Console.ReadLine();
                //this is the same as using a Try Catch because it is a built in function.

                userResponseInt = int.TryParse(userResponse, out number);
                Console.WriteLine("Invalid input please select a valid input from the Menu");
                // try
                // {
                //     int userResponseInt = int.Parse(userResponse);
                // }
                // catch (FormatException ex){
                //     throw new FormatException("There was a problem with parsing the user input", ex);
                // }

            } while (userResponseInt == false);

        }
    }
}
