using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookRegistration
{
    public class Book
    {
        private int _isbn;

        public Book(decimal price, string title)
        {
            Price = price;
            Title = title;
        }

        public decimal Price { get; set; }

        public string Title { get; set; }
        public int Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public overrideToString()
        {
            throw new System.NotImplementedException();
        }
    }
}