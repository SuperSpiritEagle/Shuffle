using System;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string commandExit = "exit";

            int size = 4;
            int[] numbers = new int[size];

            bool isWork = true;

            FillArray(numbers);
            Console.WriteLine("Исходный массив");

            Print(numbers);

            Console.WriteLine($"\nДля выхода из программы введите {commandExit} для array shuffle нажни enter");

            while (isWork)
            {
                userInput = Console.ReadLine();

                if (userInput == commandExit)
                {
                    isWork = false;
                }
                else
                {
                    Shuffle(numbers);
                    Print(numbers);
                }
            }
        }

        private static void Shuffle(int[] numbers)
        {
            Random random = new Random();

            int swap;
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                swap = random.Next(i + 1);
                temp = numbers[swap];
                numbers[swap] = numbers[i];
                numbers[i] = temp;
            }
        }

        private static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"[{numbers[i]}]");
            }

            Console.WriteLine();
        }

        private static void FillArray(int [] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }
        }
    }
}
