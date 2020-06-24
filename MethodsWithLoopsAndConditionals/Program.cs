using System;
using System.Globalization;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCounter();
            Console.WriteLine();
            NumberCounter1();
            Console.WriteLine();
            NumberCounter2(5 , 7);
            Console.WriteLine();
            NumberCounter3(20);
            Console.WriteLine();
            NumberCounter4(0);
            Console.WriteLine();
            Console.WriteLine("How old are you");

            var userInput = (Console.ReadLine();

            int userAge = int.Parse(userInput);

            VotingAge(userAge);




        }
        public static void NumberCounter()
        {
            int num1 = 1000;
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(num1);
                num1--;
            }

        }
        public static void NumberCounter1()
        {
            int num2 = 3;
            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(num2);
                num2 += 3;
            }
        }
        public static bool NumberCounter2(int x, int y)
        {
            bool isTrue = true;
            if (x == y)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static void NumberCounter3(int x)
        {
            if(x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                Console.WriteLine($"{x} is odd");
            }
        }
        public static void NumberCounter4(int x)
        {
            if(x < 0)
            {
                Console.WriteLine($"{x} is negative");
            }
            else
            {
                Console.WriteLine($"{x} is positive");
            }
        }
        public static void VotingAge(int x)
        {
            if(x >= 18)
            {
                Console.WriteLine($"You are {x} years old, you are old enough to vote.");
            }
            else
            {
                Console.WriteLine($"You are {x} years old, you are not old enough to vote. Sorry!!");
            }
        }
    }
}             
