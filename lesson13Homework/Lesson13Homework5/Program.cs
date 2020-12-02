using System;

namespace Lesson13Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article();
            article1.Name = "Book";
            article1.Grocery = "Forum";
            article1.Price=567.50;

            Article article2 = new Article();
            article2.Name = "Polo";
            article2.Grocery = "Forum";
            article2.Price = 345;

            Article article3 = new Article();
            article3.Name = "Phone";
            article3.Grocery = "Victoria Gardens";
            article3.Price = 10500.50;

            Article[] _articles = new Store[3];
            _articles[0] = article1;
            _articles[1] = article2;
            _articles[2] = article3;

            Console.WriteLine("Please, choose article from 1 to 3: ");
            int choose_article = int.Parse(Console.ReadLine());
            switch(choose_article)
            {
                case 1:
                    {
                        Console.WriteLine($"Article's name:{article1.Name}, Article's grocery:{article1.Grocery}, Article's price:{article1.Price}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Article's name:{article2.Name}, Article's grocery:{article2.Grocery}, Article's price:{article2.Price}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Article's name:{article3.Name}, Article's grocery:{article3.Grocery}, Article's price:{article3.Price}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sorry, there is not your article!");
                        break;
                    }
            }

        }
    }
}
