using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13Homework4
{
    class MyMatrix
    {
        private int row;
        private int column;

        public int Row //property
        {
            get { return row; }
            set { row = value; }
        }
        public int Column //property
        {
            get { return column; }
            set { column = value; }
        }
        public MyMatrix(int row,int column) //constructor
        {
            this.row = row;
            this.column = column;
        }
        public void CreateMatrix(int row,int column) //method
        {
            int[,] matrix = new int[row, column];
            Random rand = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[row, column] = rand.Next(0, 10);
                    Console.Write($"{matrix[row, column]}+ \t");
                }
                Console.WriteLine();
            }
        }
    }
}
