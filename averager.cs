using System;

namespace Averager
{
    class Averager
    {

        static void Main()
        {
            //Introduction to program
            Console.WriteLine("Welcome to Averager!");
            Console.WriteLine("Type any number as many times as you like.");
            Console.WriteLine("When you are done, type 'd' to find the average!");
            Console.WriteLine("Press 'q' to quit.");

            //recieve user input and process the average when requested
            get_input();
        }

        //this method recieves user input as an int to work out the average upon request
        static void get_input()
        {
            //stores the amount of numbers the user has typed in
            int count = 0;
            //the sum total of each number the user has provided
            int total = 0;

            while (true)
            {
                //store user input into 'input'
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                //if user types 'q', quit the program
                if (input.ToLower() == "q")
                {
                    break;
                }

                //check to see if input is valid
                try
                {
                    //if user input is a d, end the loop and find the avg
                    if (input.ToLower() == "d")
                    {
                        Console.WriteLine(total / count);
                        count = 0;
                        total = 0;
                    }
                    //else continue the loop
                    else
                    {
                        total += int.Parse(input);
                        count++;
                    }
                }
                //if wrong input is recievd, resart loop and ifnrom user to 'try again'
                catch (FormatException)
                {
                    Console.WriteLine("Try again");
                    continue;
                }

            }
        }
    }
}

