namespace Library_of_books
{
    partial class fmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.bnChangeData = new System.Windows.Forms.Button();
            this.dgvShowingField = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bnAddNewData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bnDeleteData = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPublishingYear = new System.Windows.Forms.TextBox();
            this.tbPublishingHouse = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchAuthor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchPublishingYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchPublishingHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.bnSearchBook = new System.Windows.Forms.Button();
            this.tbSearchAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowingField)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bnChangeData
            // 
            this.bnChangeData.Location = new System.Drawing.Point(8, 239);
            this.bnChangeData.Name = "bnChangeData";
            this.bnChangeData.Size = new System.Drawing.Size(155, 34);
            this.bnChangeData.TabIndex = 2;
            this.bnChangeData.Text = "Change book information";
            this.bnChangeData.UseVisualStyleBackColor = true;
            this.bnChangeData.Click += new System.EventHandler(this.bnChangeData_Click);
            // 
            // dgvShowingField
            // 
            this.dgvShowingField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowingField.Location = new System.Drawing.Point(12, 102);
            this.dgvShowingField.Name = "dgvShowingField";
            this.dgvShowingField.RowHeadersVisible = false;
            this.dgvShowingField.Size = new System.Drawing.Size(588, 311);
            this.dgvShowingField.TabIndex = 3;
            this.dgvShowingField.DoubleClick += new System.EventHandler(this.dgvShowingField_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.bnAddNewData);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bnDeleteData);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbPublishingYear);
            this.groupBox1.Controls.Add(this.bnChangeData);
            this.groupBox1.Controls.Add(this.tbPublishingHouse);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.tbNameBook);
            this.groupBox1.Location = new System.Drawing.Point(606, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected book";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(166, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description";
            // 
            // bnAddNewData
            // 
            this.bnAddNewData.Location = new System.Drawing.Point(8, 198);
            this.bnAddNewData.Name = "bnAddNewData";
            this.bnAddNewData.Size = new System.Drawing.Size(155, 35);
            this.bnAddNewData.TabIndex = 19;
            this.bnAddNewData.Text = "Add new book";
            this.bnAddNewData.UseVisualStyleBackColor = true;
            this.bnAddNewData.Click += new System.EventHandler(this.bnAddNewData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Publishing year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Publishing house";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name of the book";
            // 
            // bnDeleteData
            // 
            this.bnDeleteData.Location = new System.Drawing.Point(8, 279);
            this.bnDeleteData.Name = "bnDeleteData";
            this.bnDeleteData.Size = new System.Drawing.Size(155, 34);
            this.bnDeleteData.TabIndex = 11;
            this.bnDeleteData.Text = "Delete book";
            this.bnDeleteData.UseVisualStyleBackColor = true;
            this.bnDeleteData.Click += new System.EventHandler(this.bnDeleteData_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(169, 86);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(181, 227);
            this.tbDescription.TabIndex = 6;
            // 
            // tbPublishingYear
            // 
            this.tbPublishingYear.Location = new System.Drawing.Point(2, 172);
            this.tbPublishingYear.Name = "tbPublishingYear";
            this.tbPublishingYear.Size = new System.Drawing.Size(159, 20);
            this.tbPublishingYear.TabIndex = 10;
            // 
            // tbPublishingHouse
            // 
            this.tbPublishingHouse.Location = new System.Drawing.Point(2, 130);
            this.tbPublishingHouse.Name = "tbPublishingHouse";
            this.tbPublishingHouse.Size = new System.Drawing.Size(159, 20);
            this.tbPublishingHouse.TabIndex = 9;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(2, 86);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(159, 20);
            this.tbAuthor.TabIndex = 8;
            // 
            // tbNameBook
            // 
            this.tbNameBook.Location = new System.Drawing.Point(0, 41);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(159, 20);
            this.tbNameBook.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSearchAuthor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSearchPublishingYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSearchPublishingHouse);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSearchName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bnSearchBook);
            this.groupBox2.Controls.Add(this.tbSearchAutor);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 76);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search parametrs";
            // 
            // cbSearchAuthor
            // 
            this.cbSearchAuthor.FormattingEnabled = true;
            this.cbSearchAuthor.Location = new System.Drawing.Point(101, 43);
            this.cbSearchAuthor.Name = "cbSearchAuthor";
            this.cbSearchAuthor.Size = new System.Drawing.Size(124, 21);
            this.cbSearchAuthor.TabIndex = 17;
            this.cbSearchAuthor.DropDownClosed += new System.EventHandler(this.cbSearchAuthor_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Publishing year";
            // 
            // tbSearchPublishingYear
            // 
            this.tbSearchPublishingYear.Location = new System.Drawing.Point(652, 43);
            this.tbSearchPublishingYear.Name = "tbSearchPublishingYear";
            this.tbSearchPublishingYear.Size = new System.Drawing.Size(104, 20);
            this.tbSearchPublishingYear.TabIndex = 16;
            this.tbSearchPublishingYear.TextChanged += new System.EventHandler(this.tbSearchPublishingYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Publishing house";
            // 
            // tbSearchPublishingHouse
            // 
            this.tbSearchPublishingHouse.Location = new System.Drawing.Point(438, 43);
            this.tbSearchPublishingHouse.Name = "tbSearchPublishingHouse";
            this.tbSearchPublishingHouse.Size = new System.Drawing.Size(160, 20);
            this.tbSearchPublishingHouse.TabIndex = 14;
            this.tbSearchPublishingHouse.TextChanged += new System.EventHandler(this.tbSearchPublishingHouse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name of the book";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(261, 43);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(146, 20);
            this.tbSearchName.TabIndex = 12;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // bnSearchBook
            // 
            this.bnSearchBook.Location = new System.Drawing.Point(806, 27);
            this.bnSearchBook.Name = "bnSearchBook";
            this.bnSearchBook.Size = new System.Drawing.Size(133, 36);
            this.bnSearchBook.TabIndex = 2;
            this.bnSearchBook.Text = "Show all books";
            this.bnSearchBook.UseVisualStyleBackColor = true;
            this.bnSearchBook.Click += new System.EventHandler(this.bnShowAllBook_Click);
            // 
            // tbSearchAutor
            // 
            this.tbSearchAutor.Location = new System.Drawing.Point(6, 43);
            this.tbSearchAutor.Name = "tbSearchAutor";
            this.tbSearchAutor.Size = new System.Drawing.Size(88, 20);
            this.tbSearchAutor.TabIndex = 8;
            this.tbSearchAutor.TextChanged += new System.EventHandler(this.tbSearchAutor_TextChanged);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShowingField);
            this.Controls.Add(this.label1);
            this.Name = "fmMain";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowingField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnChangeData;
        private System.Windows.Forms.DataGridView dgvShowingField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnDeleteData;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPublishingYear;
        private System.Windows.Forms.TextBox tbPublishingHouse;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSearchAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnSearchBook;
        private System.Windows.Forms.TextBox tbSearchPublishingYear;
        private System.Windows.Forms.TextBox tbSearchPublishingHouse;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchAutor;
        private System.Windows.Forms.Button bnAddNewData;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label10;
    }
}

