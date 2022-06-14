using System.Data.SqlClient;

namespace BookRegistration
{
    /// <summary>
    /// This method assists with adding and getting customer information from a T-SQL database.
    /// </summary>
    public class CustomerDB
    {
        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="customer">The customer information to be added.</param>
        public static void Add(Customer customer)
        {
            // Get Connection
            using SqlConnection con = GetCustomerDBConnection();

            // Prepare insert statement
            SqlCommand insertCmd = new();

            insertCmd.Connection = con;

            // Parameterized query
            insertCmd.CommandText = "INSERT INTO Customer (DateOfBirth, FirstName, LastName, Title) " +
                "VALUES(@DOB, @FName, @LName, @Title)";

            insertCmd.Parameters.AddWithValue("@DOB", customer.DateOfBirth);
            insertCmd.Parameters.AddWithValue("@FName", customer.FirstName);
            insertCmd.Parameters.AddWithValue("@LName", customer.LastName);
            insertCmd.Parameters.AddWithValue("@Title", customer.Title);

            // Open connection to the database
            con.Open();

            // Execute insert query
            insertCmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets all of the customers from the database.
        /// </summary>
        /// <returns>All of the customers from the database wrapped up into a list.</returns>
        public static List<Customer> GetAllCustomers()
        {
            using SqlConnection con = GetCustomerDBConnection();

            // Prepare the query
            SqlCommand selCmd = new()
            {
                Connection = con,
                CommandText = "Select CustomerID, DateOfBirth, FirstName, " +
                "LastName, Title From Customer Order By LastName"
            };

            // Open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selCmd.ExecuteReader();

            List<Customer> customer = new();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CustomerID"]);
                string fName = reader["FirstName"].ToString();
                string lName = reader["LastName"].ToString();
                DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);
                string title = reader["Title"].ToString();


                Customer tempcust = new(dob, fName, lName, title);
                tempcust.CustomerID = id;

                customer.Add(tempcust);

            }
            // Return list of students
            return customer;
        }

        /// <summary>
        /// Helper method which simplifies the connection to the database 
        /// </summary>
        /// <returns>A Sql Connection to the database</returns>
        public static SqlConnection GetCustomerDBConnection()
        {
            // Establish connection to database
            return new SqlConnection("Data Source = localhost; " +
              "Initial Catalog = BookRegistration; Integrated Security = True");
        }
    }
}