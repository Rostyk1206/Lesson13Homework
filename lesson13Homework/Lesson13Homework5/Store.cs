using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13Homework5
{
    class Store:Article
    {
        private Article[] _articles;
        public Article this[int index]
        {
            get { return _articles[index]; }
            set { _articles[index] = value; }
        }
    }
}
