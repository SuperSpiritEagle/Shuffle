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

            FillingArray(numbers);
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

        private static void Shuffle(int[] array)
        {
            Random random = new Random();

            int swap;
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                swap = random.Next(i + 1);
                temp = array[swap];
                array[swap] = array[i];
                array[i] = temp;
            }
        }

        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static void FillingArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
        }
    }
}
