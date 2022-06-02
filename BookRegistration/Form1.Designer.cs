namespace BookRegistration
{
    partial class FrmBookRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnRegisterBook = new System.Windows.Forms.Button();
            this.CmbCustomerName = new System.Windows.Forms.ComboBox();
            this.CmbBookTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(331, 16);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(103, 44);
            this.BtnAddCustomer.TabIndex = 1;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(331, 103);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(103, 44);
            this.BtnAddBook.TabIndex = 4;
            this.BtnAddBook.Text = "Add Book";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            // 
            // BtnRegisterBook
            // 
            this.BtnRegisterBook.Location = new System.Drawing.Point(112, 154);
            this.BtnRegisterBook.Name = "BtnRegisterBook";
            this.BtnRegisterBook.Size = new System.Drawing.Size(103, 44);
            this.BtnRegisterBook.TabIndex = 5;
            this.BtnRegisterBook.Text = "Register Book";
            this.BtnRegisterBook.UseVisualStyleBackColor = true;
            // 
            // CmbCustomerName
            // 
            this.CmbCustomerName.FormattingEnabled = true;
            this.CmbCustomerName.Location = new System.Drawing.Point(112, 17);
            this.CmbCustomerName.Name = "CmbCustomerName";
            this.CmbCustomerName.Size = new System.Drawing.Size(208, 23);
            this.CmbCustomerName.TabIndex = 0;
            // 
            // CmbBookTitle
            // 
            this.CmbBookTitle.FormattingEnabled = true;
            this.CmbBookTitle.Location = new System.Drawing.Point(112, 67);
            this.CmbBookTitle.Name = "CmbBookTitle";
            this.CmbBookTitle.Size = new System.Drawing.Size(208, 23);
            this.CmbBookTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registration Date:";
            // 
            // DtpRegistrationDate
            // 
            this.DtpRegistrationDate.Location = new System.Drawing.Point(112, 114);
            this.DtpRegistrationDate.Name = "DtpRegistrationDate";
            this.DtpRegistrationDate.Size = new System.Drawing.Size(208, 23);
            this.DtpRegistrationDate.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(242, 154);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(103, 44);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.DtpRegistrationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBookTitle);
            this.Controls.Add(this.CmbCustomerName);
            this.Controls.Add(this.BtnRegisterBook);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.BtnAddCustomer);
            this.Location = new System.Drawing.Point(1200, 137);
            this.Name = "FrmBookRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddCustomer;
        private Button BtnAddBook;
        private Button BtnRegisterBook;
        private ComboBox CmbCustomerName;
        private ComboBox CmbBookTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker DtpRegistrationDate;
        private Button BtnExit;
    }
}