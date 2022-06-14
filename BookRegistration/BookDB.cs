using System.Data.SqlClient;
#nullable disable


namespace BookRegistration
{
    /// <summary>
    /// This method assists with adding and getting Book information from a T-SQL database.
    /// </summary>
    public class BookDB
    {
        /// <summary>
        /// Adds a book to the database
        /// </summary>
        /// <param name="book">The book information for the book to be added.</param>
        public static void Add(Book book)
        {
            // Get Connection
            using SqlConnection con = DBHelper.GetConnection();

            // Prepare insert statement
            SqlCommand insertCmd = new()
            {
                Connection = con,

                // Parameterized query
                CommandText = "Insert Into Book(ISBN, Price, Title)" +
                "Values (@ISBN, @Price, @Title)"
            };
            insertCmd.Parameters.AddWithValue("@ISBN", book.Isbn);
            insertCmd.Parameters.AddWithValue("@Price", book.Price);
            insertCmd.Parameters.AddWithValue("@Title", book.Title);
            
            // Open connection to the database
            con.Open();

            // Execute insert query
            insertCmd.ExecuteNonQuery();
        }



        /// <summary>
        /// Gets all Book information from the database.
        /// </summary>
        /// <returns>All the Book information wrapped up into a List</returns>
        public static List<Book> GetAllBooks()
        {
            using SqlConnection con = DBHelper.GetConnection();

            // Prepare the query
            SqlCommand selCmd = new()
            {
                Connection = con,
                CommandText = "Select ISBN, Price, Title" +
                " From Book Order By Title"
            };

            // Open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selCmd.ExecuteReader();
            List<Book> books = new();
            while (reader.Read())
            {
                string isbn = reader["ISBN"].ToString();
                decimal price = Convert.ToDecimal(reader["Price"]);
                string title = reader["Title"].ToString();

                Book book = new(isbn, price, title);
                books.Add(book);
            }
            return books;
        }
    }
}