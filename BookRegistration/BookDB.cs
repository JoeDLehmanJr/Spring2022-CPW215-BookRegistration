using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookRegistration
{
    public class BookDB
    {
        public void add(Book book)
        {
            throw new System.NotImplementedException();
        }

        private System.Data.SqlClient.SqlConmection GetBookDBConnection()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Book> GetAllBooks()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int isbn)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}