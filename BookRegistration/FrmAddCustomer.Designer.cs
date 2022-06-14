namespace BookRegistration
{
    partial class FrmAddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtCustomerTitle = new System.Windows.Forms.TextBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnCustomerCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth:";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Location = new System.Drawing.Point(100, 113);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(208, 23);
            this.DtpDateOfBirth.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(100, 84);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(208, 23);
            this.TxtLastName.TabIndex = 2;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(100, 52);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(208, 23);
            this.TxtFirstName.TabIndex = 1;
            // 
            // TxtCustomerTitle
            // 
            this.TxtCustomerTitle.Location = new System.Drawing.Point(100, 23);
            this.TxtCustomerTitle.Name = "TxtCustomerTitle";
            this.TxtCustomerTitle.Size = new System.Drawing.Size(208, 23);
            this.TxtCustomerTitle.TabIndex = 0;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(21, 159);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(75, 48);
            this.BtnAddCustomer.TabIndex = 4;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnCustomerCancel
            // 
            this.BtnCustomerCancel.Location = new System.Drawing.Point(233, 159);
            this.BtnCustomerCancel.Name = "BtnCustomerCancel";
            this.BtnCustomerCancel.Size = new System.Drawing.Size(75, 48);
            this.BtnCustomerCancel.TabIndex = 5;
            this.BtnCustomerCancel.Text = "Cancel";
            this.BtnCustomerCancel.UseVisualStyleBackColor = true;
            this.BtnCustomerCancel.Click += new System.EventHandler(this.BtnCustomerCancel_Click);
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 223);
            this.Controls.Add(this.BtnCustomerCancel);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.TxtCustomerTitle);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource bindingSource1;
        private DateTimePicker DtpDateOfBirth;
        private TextBox TxtLastName;
        private TextBox TxtFirstName;
        private TextBox TxtCustomerTitle;
        private Button BtnAddCustomer;
        private Button BtnCustomerCancel;
    }
}