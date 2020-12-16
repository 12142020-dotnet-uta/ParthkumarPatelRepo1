using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the input from the user
            Console.WriteLine("\n Lets Play Rock Paper Scissors!! \n");
            Console.WriteLine("Enter Your Selection - \t\n Rock \t\n Paper \t\n Scissors \n Make sure to enter it exactly!!");
            string UserInput = Console.ReadLine();
            Console.WriteLine("Your Input was " + UserInput);

            //Creating a randomly selected input from the computer.
            //A array of computerInput  
            string[] computerInput = { "Rock", "Paper", "Scissors" };
            //Create a Random object  
            Random rand = new Random();
            //Generate a random index less than the size of the array.  
            int index = rand.Next(computerInput.Length);

            //Making loops to check the UserInput against the random computerInput.

            //Checking for a tie
            if (computerInput[index] == UserInput)
            {
                Console.WriteLine("It is a tie the Computer Selected " + UserInput + " as well");
            }
            //Checking if computer wins
            else if (computerInput[index] == "Rock" & UserInput == "Scissors" ||
                    computerInput[index] == "Scissors" & UserInput == "Paper" ||
                    computerInput[index] == "Paper" & UserInput == "Rock")
            {
                Console.WriteLine("Computer wins, it played " + computerInput[index]);
            }
            //Checking if user wins
            else if (UserInput == "Rock" & computerInput[index] == "Scissors" ||
                    UserInput == "Scissors" & computerInput[index] == "Paper" ||
                    UserInput == "Paper" & computerInput[index] == "Rock")
            {
                Console.WriteLine("YESSS!! You win, the computer played " + computerInput[index]);
            }
            //Checking if input is valid
            else
            {
                Console.WriteLine("Input a valid entry from above.");
            }
        }
    }
}

