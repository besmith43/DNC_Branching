using System;

namespace DNC_Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If/Else Statement\n");

            int a = 3;
            int b = 5;

            if (a < b)
            {
                Console.WriteLine($"{a} is less than {b}");
            }
            else if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is equal to {b}");
            }

            Console.WriteLine("\n\nSwitch Statement Block\n");

            int choice = 2;

            switch(choice)
            {
                case 1:
                    Console.WriteLine("the Choice is 1");
                    break;
                case 2:
                    Console.WriteLine("The Choice is 2");
                    break;
                default:
                    Console.WriteLine("The Choice was not 1 or 2");
                    break;
            }

            Console.WriteLine("\n\nWhile Loop\n");

            int count = 0;

            while (count < 5)
            {
                Console.WriteLine($"The count is {count}");
                count++;
            }

            Console.WriteLine("\n\nDo-While Loop\n");

            count = 0; // can't redeclare a variable, so I am just resetting the value to zero

            do
            {
                Console.WriteLine($"The count is {count}");
                count++;
            } while(count < 5);

            Console.WriteLine("\n\nFor Loop\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The count is {count}");
            }

            Console.WriteLine("\n\nForEach Loop\n");

            int[] numbers = new int[] {0, 1, 2, 3, 4};

            foreach (int number in numbers)
            {
                Console.WriteLine($"The count is {number}");
            }

            Console.ReadLine();
        }
    }
}
