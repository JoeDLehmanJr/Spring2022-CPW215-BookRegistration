using System.Data.SqlClient;

namespace BookRegistration
{
    /// <summary>
    /// Helper method which simplifies the connection to the database 
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// Helper method which simplifies the connection to the database 
        /// </summary>
        /// <returns>A Sql Connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            // Establish connection to database
            return new SqlConnection("Data Source = localhost; Initial Catalog = BookRegistration; Integrated Security = True");
        }
    }
}