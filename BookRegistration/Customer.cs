using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookRegistration
{
    /// <summary>
    /// Creates a Customer object with five 
    /// characteristics: the customerid, the date of birth, 
    /// the first name, last name, and personnel title.
    /// </summary>
    public class Customer
    {
        private int _customerID;

        /// <summary>
        /// Constructor for creating the customer object
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="title"></param>
        public Customer(DateTime dateOfBirth, string fName, string lName, string title)
        {
            this.DateOfBirth = dateOfBirth;
            FirstName = fName;
            LastName = lName;
            Title = title;
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
        /// Gets and sets the date of birth attribute.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets and sets the first name attribute.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the last name attribute.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// gets the full name by concatenate the last 
        /// name, a comma and a space, and the first name.
        /// </summary>
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        /// <summary>
        /// The string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName;
        }

        /// <summary>
        /// Gets and sets the title attribute.
        /// </summary>
        public string Title { get; set; }
    }
}