using System;

namespace Lesson13Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter array size:");
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            Random rand = new Random();
            for (int i=0;i<N;i++)
            {
                array[i] = rand.Next(1, 100);
                Console.WriteLine($"Element of array {i+1} : {array[i]}");
            }

            int max = 0;
            int min = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            double avg = sum / N;

            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"Avg:{avg}");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd number:{array[i]}");
                }
            }
        }
    }
}
