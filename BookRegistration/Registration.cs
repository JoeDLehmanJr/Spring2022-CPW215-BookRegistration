using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookRegistration
{
    /// <summary>
    /// Creates a book registration object with three characteristics: the isbn, the CustomerId, and the registration date.
    /// </summary>
    public class Registration
    {
        private int _customerID;
        private string _isbn;

        /// <summary>
        /// Constructor for creating the book registration object
        /// </summary>
        /// <param name="custId">The customer identification number to uniquely identify an individual.</param>
        /// <param name="isbn">The international standard book number, is used to uniquely identify a single book.</param>
        /// <param name="registrationDate">The date the book was checked out.</param>
        public Registration(int custId, string isbn, DateTime registrationDate)
        {
            this.CustomerID = custId;
            this.Isbn = isbn;
            this.RegDate = registrationDate;
        }
        /// <summary>
        /// Getter and setter for the _customerID field.
        /// </summary>
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        /// <summary>
        /// Getter and setter for the _isbn field.
        /// </summary>
        public String Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        /// <summary>
        /// Getter and setter for the RegDate attribute.
        /// </summary>
        public DateTime RegDate { get; set; }
    }
}