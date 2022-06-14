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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void BtnCustomerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            DateTime _1 = Convert.ToDateTime(DtpDateOfBirth.Value);
            String title = TxtCustomerTitle.Text;
            String fName = TxtFirstName.Text;
            String lName = TxtLastName.Text;

            Customer newCustomer = new(_1, fName, lName, title);

            CustomerDB.Add(newCustomer);
            MessageBox.Show("Customer added successfully!");
            Close();
        }
    }
}
