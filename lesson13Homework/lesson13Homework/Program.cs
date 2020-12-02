using System;
using System.Text;


namespace lesson13Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["телефон"]);
            Console.WriteLine(dictionary["басейн"]);
            Console.WriteLine(dictionary["зошит"]);
            Console.WriteLine(dictionary["дощ"]);
            Console.WriteLine(dictionary["вікно"]);
            Console.WriteLine(dictionary["телефон"]);
            Console.WriteLine(dictionary["бассейн"]);
            Console.WriteLine(dictionary["тетрадь"]);
            Console.WriteLine(dictionary["дождь"]);
            Console.WriteLine(dictionary["окно"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
        }
    }
}

