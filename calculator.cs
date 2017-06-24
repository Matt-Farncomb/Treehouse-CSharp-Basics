using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            //intro
            Console.WriteLine("Welcome to the calculator");
            calculate();
        }

        static void calculate()
        {
            int answer = 0;

            Console.Write("Number: ");
            string number = Console.ReadLine();
            int numb = int.Parse(number);
            Console.Write("Operator: ");
            string operation = Console.ReadLine();
            Console.Write("Number: ");
            string number_2 = Console.ReadLine();
            int numb_2 = int.Parse(number_2);

            //complete the 'algorithm' according to what operator the user chose
            if (operation == "+")
            {
                answer = numb + numb_2;
            }
            else if (operation == "-")
            {
                answer = numb - numb_2;
            }
            else if (operation == "/")
            {
                answer = numb / numb_2;
            }
            else if (operation == "*")
            {
                answer = numb * numb_2;
            }

            //print tbe answer
            Console.WriteLine("Answer = " + answer);
        }
    }
}