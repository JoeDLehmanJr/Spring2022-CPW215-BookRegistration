using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookRegistration
{
    /// <summary>
    /// Creates a book object with three characteristics: the isbn, the title, and the price
    /// </summary>
    public class Book
    {
        
        private String _isbn;

        /// <summary>
        /// Constructor for creating the book object
        /// </summary>
        /// <param name="isbn">The international standard book number, is used to uniquely identify a single book.</param>
        /// <param name="price">The price of the book.</param>
        /// <param name="title">The title of the book.</param>
        public Book(String isbn, decimal price, string title)
        {
            Isbn = isbn;
            Price = price;
            Title = title;
        }

        /// <summary>
        /// Getter and setter for the price attribute.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Getter and setter for the title attribute.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Getter and setter for the isbn field.
        /// </summary>
        public String Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        /// <summary>
        /// The string representation of the object
        /// </summary>
        /// <returns>The string representation of the object</returns>
        public override string ToString()
        {
            return Title;
        }
    }
}