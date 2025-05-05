namespace Project.WinUI
{
    partial class Form1
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
            this.TxtMember = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.CmbCategories = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnLoan = new System.Windows.Forms.Button();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.TxtPageCount = new System.Windows.Forms.TextBox();
            this.LblMember = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.TxtBookIdForLoan = new System.Windows.Forms.TextBox();
            this.LblKitapID = new System.Windows.Forms.Label();
            this.LblPageCount = new System.Windows.Forms.Label();
            this.LblKategori = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMember
            // 
            this.TxtMember.Location = new System.Drawing.Point(665, 386);
            this.TxtMember.Name = "TxtMember";
            this.TxtMember.Size = new System.Drawing.Size(100, 22);
            this.TxtMember.TabIndex = 1;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(107, 34);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(100, 22);
            this.TxtTitle.TabIndex = 1;
            // 
            // DgvBooks
            // 
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Location = new System.Drawing.Point(454, 28);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.RowHeadersWidth = 51;
            this.DgvBooks.RowTemplate.Height = 24;
            this.DgvBooks.Size = new System.Drawing.Size(438, 321);
            this.DgvBooks.TabIndex = 4;
            // 
            // CmbCategories
            // 
            this.CmbCategories.FormattingEnabled = true;
            this.CmbCategories.Location = new System.Drawing.Point(144, 259);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.Size = new System.Drawing.Size(121, 24);
            this.CmbCategories.TabIndex = 5;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(107, 78);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 6;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(45, 308);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(162, 56);
            this.BtnAddBook.TabIndex = 7;
            this.BtnAddBook.Text = "Add";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnLoan
            // 
            this.BtnLoan.Location = new System.Drawing.Point(350, 399);
            this.BtnLoan.Name = "BtnLoan";
            this.BtnLoan.Size = new System.Drawing.Size(170, 45);
            this.BtnLoan.TabIndex = 8;
            this.BtnLoan.Text = "Loan";
            this.BtnLoan.UseVisualStyleBackColor = true;
            this.BtnLoan.Click += new System.EventHandler(this.BtnLoan_Click);
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(107, 124);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(100, 22);
            this.TxtAuthor.TabIndex = 9;
            // 
            // TxtPageCount
            // 
            this.TxtPageCount.Location = new System.Drawing.Point(102, 191);
            this.TxtPageCount.Name = "TxtPageCount";
            this.TxtPageCount.Size = new System.Drawing.Size(105, 22);
            this.TxtPageCount.TabIndex = 10;
            // 
            // LblMember
            // 
            this.LblMember.AutoSize = true;
            this.LblMember.Location = new System.Drawing.Point(557, 389);
            this.LblMember.Name = "LblMember";
            this.LblMember.Size = new System.Drawing.Size(57, 16);
            this.LblMember.TabIndex = 11;
            this.LblMember.Text = "Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(27, 81);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(38, 16);
            this.LblPrice.TabIndex = 13;
            this.LblPrice.Text = "Price";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(39, 130);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(45, 16);
            this.LblAuthor.TabIndex = 14;
            this.LblAuthor.Text = "Author";
            // 
            // TxtBookIdForLoan
            // 
            this.TxtBookIdForLoan.Location = new System.Drawing.Point(665, 425);
            this.TxtBookIdForLoan.Name = "TxtBookIdForLoan";
            this.TxtBookIdForLoan.Size = new System.Drawing.Size(100, 22);
            this.TxtBookIdForLoan.TabIndex = 15;
            // 
            // LblKitapID
            // 
            this.LblKitapID.AutoSize = true;
            this.LblKitapID.Location = new System.Drawing.Point(584, 428);
            this.LblKitapID.Name = "LblKitapID";
            this.LblKitapID.Size = new System.Drawing.Size(53, 16);
            this.LblKitapID.TabIndex = 16;
            this.LblKitapID.Text = "Kitap ID";
            // 
            // LblPageCount
            // 
            this.LblPageCount.AutoSize = true;
            this.LblPageCount.Location = new System.Drawing.Point(6, 197);
            this.LblPageCount.Name = "LblPageCount";
            this.LblPageCount.Size = new System.Drawing.Size(77, 16);
            this.LblPageCount.TabIndex = 17;
            this.LblPageCount.Text = "Page Count";
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Location = new System.Drawing.Point(58, 267);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(57, 16);
            this.LblKategori.TabIndex = 18;
            this.LblKategori.Text = "Kategori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbCategories);
            this.groupBox1.Controls.Add(this.LblKategori);
            this.groupBox1.Controls.Add(this.TxtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.BtnAddBook);
            this.groupBox1.Controls.Add(this.LblPageCount);
            this.groupBox1.Controls.Add(this.LblPrice);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.LblAuthor);
            this.groupBox1.Controls.Add(this.TxtPageCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 380);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(857, 383);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail.TabIndex = 20;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(857, 439);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(100, 22);
            this.TxtPhone.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 503);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblKitapID);
            this.Controls.Add(this.TxtBookIdForLoan);
            this.Controls.Add(this.LblMember);
            this.Controls.Add(this.BtnLoan);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.TxtMember);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtMember;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.ComboBox CmbCategories;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnLoan;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.TextBox TxtPageCount;
        private System.Windows.Forms.Label LblMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.TextBox TxtBookIdForLoan;
        private System.Windows.Forms.Label LblKitapID;
        private System.Windows.Forms.Label LblPageCount;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPhone;
    }
}

