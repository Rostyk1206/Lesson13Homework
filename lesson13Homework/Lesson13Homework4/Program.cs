using System;

namespace Lesson13Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of row:");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size of column:");
            int column = int.Parse(Console.ReadLine()); 
           
            MyMatrix matrix1 = new MyMatrix(row,column);
            matrix1.CreateMatrix(row,column);
        }
    }
}
