using System.Data.SqlClient;

namespace BookRegistration
{
    /// <summary>
    /// This method assists with adding and getting Book reservation information from a T-SQL database.
    /// </summary>
    public class BookRegistrationDB
    {
        /// <summary>
        /// Adds a Book reservation information (customerId, ISBN, and reservation date) to the database.
        /// </summary>
        /// <param name="reg">A reservation object(customerId, ISBN, and reservation date).</param>
        /// <returns>True if the addition was successful, false if not.</returns>
        public static bool RegisterBook(Registration reg)
        {
            // Get Connection
            using SqlConnection con = DBHelper.GetConnection();
            // Prepare insert statement
            SqlCommand insertCmd = new();
            insertCmd.Connection = con;

            // Parameterized query
            insertCmd.CommandText = "Insert Into Registration(CustomerID, ISBN, RegDate)" +
                "Values (@CustomerID, @ISBN, @RegDate)";

            insertCmd.Parameters.AddWithValue("@CustomerID", reg.CustomerID);
            insertCmd.Parameters.AddWithValue("@ISBN", reg.Isbn);
            insertCmd.Parameters.AddWithValue("@RegDate", reg.RegDate);

            // Open connection to the database
            con.Open();

            // Execute insert query
            int rows = insertCmd.ExecuteNonQuery();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}