namespace BookRegistration
{
    public partial class FrmBookRegistration : Form
    {
        public FrmBookRegistration()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmBookRegistration_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer newCustomer = new();
            newCustomer.ShowDialog();

            PopulateComboBoxes();
        }
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            FrmAddBook newBook = new();
            newBook.ShowDialog();

            PopulateComboBoxes();
        }


        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CmbCustomerName.SelectedIndex ==-1)
            {
                msg += "You must select a customer.\n";
            }
            if (CmbBookTitle.SelectedIndex == -1)
            {
                msg += "You must select a customer.\n";
            }
            if (msg == "" && DtpChanged)
            {
                Customer selectedCust = (Customer) CmbCustomerName.SelectedItem as Customer;
                Book selectedBook = (Book) CmbBookTitle.SelectedItem as Book;
                DateTime selectedDate = DtpRegistrationDate.Value;

                Registration newReg = new(selectedCust.CustomerID, selectedBook.Isbn, selectedDate);
                bool isSuccessful = BookRegistrationDB.RegisterBook(newReg);
                if (isSuccessful)
                {
                    MessageBox.Show("Registration was successful!");
                    CmbCustomerName.SelectedIndex = -1;
                    CmbBookTitle.SelectedIndex = -1;
                    DtpRegistrationDate.ResetText();
                    DtpChanged = false;
                }
                else
                {
                    MessageBox.Show("Registration failed!");
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
        private void DtpRegistrationDate_ValueChanged(object sender, EventArgs e)
        {
            DtpChanged = true;
        }
        // class level boolean variable to indicate if the date picker has change.
        // True if it has, false if it hasn't.
        private bool DtpChanged = false;

        /// <summary>
        /// This method refreshes both the Customer's and Book's combo boxes.
        /// </summary>
        private void PopulateComboBoxes()
        {
            // Refreshes the customer's combo box.
            CmbCustomerName.Items.Clear();
            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer currCustomer in customers)
            {
                // Add entire Customer object into combo box
                CmbCustomerName.Items.Add(currCustomer);
            }

            // Refreshes the book's combo box.
            CmbBookTitle.Items.Clear();
            List<Book> books = BookDB.GetAllBooks();

            foreach (Book CurrBook in books)
            {
                // Add entire Book object into combo box
                CmbBookTitle.Items.Add(CurrBook);
            }
        }
    }
}