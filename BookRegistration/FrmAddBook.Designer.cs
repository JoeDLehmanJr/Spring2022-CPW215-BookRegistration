namespace BookRegistration
{
    partial class FrmAddBook
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
            this.TxtBookTitle = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBookCancel = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.TxtBookIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBookTitle
            // 
            this.TxtBookTitle.Location = new System.Drawing.Point(89, 45);
            this.TxtBookTitle.Name = "TxtBookTitle";
            this.TxtBookTitle.Size = new System.Drawing.Size(208, 23);
            this.TxtBookTitle.TabIndex = 1;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(89, 77);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(208, 23);
            this.TxtPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnBookCancel
            // 
            this.BtnBookCancel.Location = new System.Drawing.Point(232, 113);
            this.BtnBookCancel.Name = "BtnBookCancel";
            this.BtnBookCancel.Size = new System.Drawing.Size(75, 48);
            this.BtnBookCancel.TabIndex = 4;
            this.BtnBookCancel.Text = "Cancel";
            this.BtnBookCancel.UseVisualStyleBackColor = true;
            this.BtnBookCancel.Click += new System.EventHandler(this.BtnBookCancel_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(20, 113);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(75, 48);
            this.BtnAddBook.TabIndex = 3;
            this.BtnAddBook.Text = "Add Customer";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // TxtBookIsbn
            // 
            this.TxtBookIsbn.Location = new System.Drawing.Point(89, 12);
            this.TxtBookIsbn.Name = "TxtBookIsbn";
            this.TxtBookIsbn.Size = new System.Drawing.Size(208, 23);
            this.TxtBookIsbn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 195);
            this.Controls.Add(this.TxtBookIsbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBookCancel);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.TxtBookTitle);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBookTitle;
        private TextBox TxtPrice;
        private Label label3;
        private Label label2;
        private Button BtnBookCancel;
        private Button BtnAddBook;
        private TextBox TxtBookIsbn;
        private Label label1;
    }
}