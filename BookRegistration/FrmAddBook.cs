using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistration
{
    public partial class FrmAddBook : Form
    {
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void BtnBookCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            String isbn = TxtBookIsbn.Text;
            decimal price = Convert.ToDecimal(TxtPrice.Text);
            String title = TxtBookTitle.Text;

            Book newBook = new(isbn, price, title);
            BookDB.Add(newBook);
            MessageBox.Show("Book added successfully!");
            Close();
        }
    }
}
