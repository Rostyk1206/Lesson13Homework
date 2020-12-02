using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13Homework5
{
    class Article
    {
        private string _name;
        private string _grocery;
        private double _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Grocery
        {
            get { return _grocery; }
            set { _grocery = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
