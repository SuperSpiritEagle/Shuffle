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

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

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
                    Shuffle(ref numbers);
                    Print(ref numbers);
                }
            }

        }


        private static int[] Shuffle(ref int[] array)
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

            return array;
        }

        private static void Print(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
