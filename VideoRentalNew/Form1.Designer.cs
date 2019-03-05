namespace VideoRentalNew
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
            this.customerBtn = new System.Windows.Forms.Button();
            this.rentalBtn = new System.Windows.Forms.Button();
            this.videoBtn = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ratingTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.copiesTxtBox = new System.Windows.Forms.TextBox();
            this.plotTxtBox = new System.Windows.Forms.TextBox();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.yearNmBox = new System.Windows.Forms.NumericUpDown();
            this.costNmBox = new System.Windows.Forms.NumericUpDown();
            this.videoAddBtn = new System.Windows.Forms.Button();
            this.videoUpdateBtn = new System.Windows.Forms.Button();
            this.videoDeleteBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.customerIDLbl = new System.Windows.Forms.Label();
            this.MovieIDLbl = new System.Windows.Forms.Label();
            this.IssuedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.returnedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.movieDeletebtn = new System.Windows.Forms.Button();
            this.movieReturnbtn = new System.Windows.Forms.Button();
            this.movieIssueBtn = new System.Windows.Forms.Button();
            this.phoneNmBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNmBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNmBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(12, 12);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(75, 23);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // rentalBtn
            // 
            this.rentalBtn.Location = new System.Drawing.Point(86, 12);
            this.rentalBtn.Name = "rentalBtn";
            this.rentalBtn.Size = new System.Drawing.Size(75, 23);
            this.rentalBtn.TabIndex = 1;
            this.rentalBtn.Text = "Rental";
            this.rentalBtn.UseVisualStyleBackColor = true;
            this.rentalBtn.Click += new System.EventHandler(this.rentalBtn_Click);
            // 
            // videoBtn
            // 
            this.videoBtn.Location = new System.Drawing.Point(160, 12);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(75, 23);
            this.videoBtn.TabIndex = 2;
            this.videoBtn.Text = "Videos";
            this.videoBtn.UseVisualStyleBackColor = true;
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // Record
            // 
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.Location = new System.Drawing.Point(12, 34);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(508, 263);
            this.Record.TabIndex = 3;
            this.Record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Record_CellClick);
            this.Record.DoubleClick += new System.EventHandler(this.Record_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Video Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rental Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Genre";
            // 
            // ratingTxtBox
            // 
            this.ratingTxtBox.Location = new System.Drawing.Point(715, 44);
            this.ratingTxtBox.Name = "ratingTxtBox";
            this.ratingTxtBox.Size = new System.Drawing.Size(116, 20);
            this.ratingTxtBox.TabIndex = 12;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(715, 78);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(116, 20);
            this.titleTxtBox.TabIndex = 13;
            // 
            // copiesTxtBox
            // 
            this.copiesTxtBox.Location = new System.Drawing.Point(715, 171);
            this.copiesTxtBox.Name = "copiesTxtBox";
            this.copiesTxtBox.Size = new System.Drawing.Size(116, 20);
            this.copiesTxtBox.TabIndex = 14;
            // 
            // plotTxtBox
            // 
            this.plotTxtBox.Location = new System.Drawing.Point(715, 206);
            this.plotTxtBox.Name = "plotTxtBox";
            this.plotTxtBox.Size = new System.Drawing.Size(116, 20);
            this.plotTxtBox.TabIndex = 15;
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(715, 238);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(116, 20);
            this.genreTxtBox.TabIndex = 16;
            // 
            // yearNmBox
            // 
            this.yearNmBox.Location = new System.Drawing.Point(715, 110);
            this.yearNmBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.yearNmBox.Name = "yearNmBox";
            this.yearNmBox.Size = new System.Drawing.Size(120, 20);
            this.yearNmBox.TabIndex = 17;
            this.yearNmBox.ValueChanged += new System.EventHandler(this.yearNmBox_ValueChanged);
            // 
            // costNmBox
            // 
            this.costNmBox.Enabled = false;
            this.costNmBox.Location = new System.Drawing.Point(715, 140);
            this.costNmBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.costNmBox.Name = "costNmBox";
            this.costNmBox.Size = new System.Drawing.Size(120, 20);
            this.costNmBox.TabIndex = 18;
            // 
            // videoAddBtn
            // 
            this.videoAddBtn.Location = new System.Drawing.Point(586, 277);
            this.videoAddBtn.Name = "videoAddBtn";
            this.videoAddBtn.Size = new System.Drawing.Size(78, 23);
            this.videoAddBtn.TabIndex = 19;
            this.videoAddBtn.Text = "Add";
            this.videoAddBtn.UseVisualStyleBackColor = true;
            this.videoAddBtn.Click += new System.EventHandler(this.videoAddBtn_Click);
            // 
            // videoUpdateBtn
            // 
            this.videoUpdateBtn.Location = new System.Drawing.Point(670, 277);
            this.videoUpdateBtn.Name = "videoUpdateBtn";
            this.videoUpdateBtn.Size = new System.Drawing.Size(81, 23);
            this.videoUpdateBtn.TabIndex = 20;
            this.videoUpdateBtn.Text = "Update";
            this.videoUpdateBtn.UseVisualStyleBackColor = true;
            this.videoUpdateBtn.Click += new System.EventHandler(this.videoUpdateBtn_Click);
            // 
            // videoDeleteBtn
            // 
            this.videoDeleteBtn.Location = new System.Drawing.Point(757, 277);
            this.videoDeleteBtn.Name = "videoDeleteBtn";
            this.videoDeleteBtn.Size = new System.Drawing.Size(78, 23);
            this.videoDeleteBtn.TabIndex = 21;
            this.videoDeleteBtn.Text = "Delete";
            this.videoDeleteBtn.UseVisualStyleBackColor = true;
            this.videoDeleteBtn.Click += new System.EventHandler(this.videoDeleteBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Customer Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phone No.";
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(143, 351);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(116, 20);
            this.CustomerNameTxtBox.TabIndex = 26;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(143, 389);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(116, 20);
            this.addressTxtBox.TabIndex = 27;
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Location = new System.Drawing.Point(200, 467);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(78, 23);
            this.customerDeleteBtn.TabIndex = 31;
            this.customerDeleteBtn.Text = "Delete";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(113, 467);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(81, 23);
            this.customerUpdateBtn.TabIndex = 30;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(29, 467);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(78, 23);
            this.customerAddBtn.TabIndex = 29;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(458, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = " Rental Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(391, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Customer Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(391, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Movie Id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(391, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Issued Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(391, 444);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Returned  Date";
            // 
            // customerIDLbl
            // 
            this.customerIDLbl.AutoSize = true;
            this.customerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLbl.Location = new System.Drawing.Point(544, 345);
            this.customerIDLbl.Name = "customerIDLbl";
            this.customerIDLbl.Size = new System.Drawing.Size(0, 20);
            this.customerIDLbl.TabIndex = 37;
            // 
            // MovieIDLbl
            // 
            this.MovieIDLbl.AutoSize = true;
            this.MovieIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieIDLbl.Location = new System.Drawing.Point(544, 377);
            this.MovieIDLbl.Name = "MovieIDLbl";
            this.MovieIDLbl.Size = new System.Drawing.Size(0, 20);
            this.MovieIDLbl.TabIndex = 38;
            // 
            // IssuedDateDtp
            // 
            this.IssuedDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssuedDateDtp.Location = new System.Drawing.Point(548, 409);
            this.IssuedDateDtp.Name = "IssuedDateDtp";
            this.IssuedDateDtp.Size = new System.Drawing.Size(103, 20);
            this.IssuedDateDtp.TabIndex = 39;
            // 
            // returnedDateDtp
            // 
            this.returnedDateDtp.Enabled = false;
            this.returnedDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnedDateDtp.Location = new System.Drawing.Point(548, 444);
            this.returnedDateDtp.Name = "returnedDateDtp";
            this.returnedDateDtp.Size = new System.Drawing.Size(103, 20);
            this.returnedDateDtp.TabIndex = 40;
            // 
            // movieDeletebtn
            // 
            this.movieDeletebtn.Location = new System.Drawing.Point(575, 484);
            this.movieDeletebtn.Name = "movieDeletebtn";
            this.movieDeletebtn.Size = new System.Drawing.Size(78, 23);
            this.movieDeletebtn.TabIndex = 43;
            this.movieDeletebtn.Text = "Delete";
            this.movieDeletebtn.UseVisualStyleBackColor = true;
            this.movieDeletebtn.Click += new System.EventHandler(this.movieDeletebtn_Click);
            // 
            // movieReturnbtn
            // 
            this.movieReturnbtn.Location = new System.Drawing.Point(488, 484);
            this.movieReturnbtn.Name = "movieReturnbtn";
            this.movieReturnbtn.Size = new System.Drawing.Size(81, 23);
            this.movieReturnbtn.TabIndex = 42;
            this.movieReturnbtn.Text = "Return";
            this.movieReturnbtn.UseVisualStyleBackColor = true;
            this.movieReturnbtn.Click += new System.EventHandler(this.movieReturnbtn_Click);
            // 
            // movieIssueBtn
            // 
            this.movieIssueBtn.Location = new System.Drawing.Point(404, 484);
            this.movieIssueBtn.Name = "movieIssueBtn";
            this.movieIssueBtn.Size = new System.Drawing.Size(78, 23);
            this.movieIssueBtn.TabIndex = 41;
            this.movieIssueBtn.Text = "Issued";
            this.movieIssueBtn.UseVisualStyleBackColor = true;
            this.movieIssueBtn.Click += new System.EventHandler(this.movieIssueBtn_Click);
            // 
            // phoneNmBox
            // 
            this.phoneNmBox.Location = new System.Drawing.Point(143, 424);
            this.phoneNmBox.Name = "phoneNmBox";
            this.phoneNmBox.Size = new System.Drawing.Size(116, 20);
            this.phoneNmBox.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 543);
            this.Controls.Add(this.phoneNmBox);
            this.Controls.Add(this.movieDeletebtn);
            this.Controls.Add(this.movieReturnbtn);
            this.Controls.Add(this.movieIssueBtn);
            this.Controls.Add(this.returnedDateDtp);
            this.Controls.Add(this.IssuedDateDtp);
            this.Controls.Add(this.MovieIDLbl);
            this.Controls.Add(this.customerIDLbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.customerDeleteBtn);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.CustomerNameTxtBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.videoDeleteBtn);
            this.Controls.Add(this.videoUpdateBtn);
            this.Controls.Add(this.videoAddBtn);
            this.Controls.Add(this.costNmBox);
            this.Controls.Add(this.yearNmBox);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.plotTxtBox);
            this.Controls.Add(this.copiesTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.ratingTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.videoBtn);
            this.Controls.Add(this.rentalBtn);
            this.Controls.Add(this.customerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNmBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNmBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button rentalBtn;
        private System.Windows.Forms.Button videoBtn;
        private System.Windows.Forms.DataGridView Record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ratingTxtBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox copiesTxtBox;
        private System.Windows.Forms.TextBox plotTxtBox;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.NumericUpDown yearNmBox;
        private System.Windows.Forms.NumericUpDown costNmBox;
        private System.Windows.Forms.Button videoAddBtn;
        private System.Windows.Forms.Button videoUpdateBtn;
        private System.Windows.Forms.Button videoDeleteBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label customerIDLbl;
        private System.Windows.Forms.Label MovieIDLbl;
        private System.Windows.Forms.DateTimePicker IssuedDateDtp;
        private System.Windows.Forms.DateTimePicker returnedDateDtp;
        private System.Windows.Forms.Button movieDeletebtn;
        private System.Windows.Forms.Button movieReturnbtn;
        private System.Windows.Forms.Button movieIssueBtn;
        private System.Windows.Forms.TextBox phoneNmBox;
    }
}

