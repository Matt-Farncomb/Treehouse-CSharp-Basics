using System;

namespace Quiz
{
    class Quiz
    {
        static void Main()
        {

            ///Introduction
            Console.WriteLine("Welcome to Quiz!");
            Console.Write("Tell us your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("Ready to begin? y/n ");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "y")
            {
                //call program that runs quiz
                quiz_time(name);
            }
            else if (confirm.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
                //break;
            }
            else
            {
                Console.WriteLine("Sorry, can you tell me again? ");
            }
        }

        static void quiz_time(string name)
        {
            //declare arrays which stores questions and a seperate array for answers
            string[] question_arr = { "What is your name? ", "What is 6 - 4? ", "What is 1 - 1 + 1 - 1 + 1? " };
            string[] answer_arr = { name, "2", "1" };
            //the variable to be used to iterate through the arrays
            int i = 0;
            //score will increase by one after each correct answer
            int score = 0;
            foreach (string value in question_arr)
            {
                Console.Write(value);
                string input = Console.ReadLine();
                if (input.ToLower() == answer_arr[i].ToLower())
                {
                    //check user input against correct answer
                    //if correct, have a score variable increase by one
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
                i++;
            }
            //after array is expended, provide score and ask if they want to play again
            Console.WriteLine("Your score: " + score);
            Console.WriteLine("Would you like to play again? y/n");
            string response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                //relaunch program
                Main();
            }
            else if (response.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}