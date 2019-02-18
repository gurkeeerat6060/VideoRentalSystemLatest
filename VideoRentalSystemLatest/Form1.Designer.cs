namespace VideoRentalSystemLatest
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
            this.RecordBox = new System.Windows.Forms.DataGridView();
            this.CustomerRecordBtn = new System.Windows.Forms.Button();
            this.RentalRecordButton = new System.Windows.Forms.Button();
            this.VideosRecordButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delUpdtVideoBox = new System.Windows.Forms.Label();
            this.UpdateVideoButton = new System.Windows.Forms.Button();
            this.DeleteVideoButton = new System.Windows.Forms.Button();
            this.AddVideoButton = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.PlotBox = new System.Windows.Forms.TextBox();
            this.CopiesBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delUpdtCustomerBox = new System.Windows.Forms.Label();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RentalIDBox = new System.Windows.Forms.Label();
            this.CustomerIDBox = new System.Windows.Forms.Label();
            this.MovieIDBox = new System.Windows.Forms.Label();
            this.DeleteRentalButton = new System.Windows.Forms.Button();
            this.ReturnDateDTP = new System.Windows.Forms.DateTimePicker();
            this.DateOfIssueDTP = new System.Windows.Forms.DateTimePicker();
            this.ReturnedButton = new System.Windows.Forms.Button();
            this.IssuedButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MostViewedMovieBUtton = new System.Windows.Forms.Button();
            this.MostRatedCustomerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecordBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordBox
            // 
            this.RecordBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordBox.Location = new System.Drawing.Point(12, 36);
            this.RecordBox.Name = "RecordBox";
            this.RecordBox.Size = new System.Drawing.Size(410, 212);
            this.RecordBox.TabIndex = 0;
            this.RecordBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordBox_CellDoubleClick);
            // 
            // CustomerRecordBtn
            // 
            this.CustomerRecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerRecordBtn.Location = new System.Drawing.Point(13, 13);
            this.CustomerRecordBtn.Name = "CustomerRecordBtn";
            this.CustomerRecordBtn.Size = new System.Drawing.Size(88, 23);
            this.CustomerRecordBtn.TabIndex = 1;
            this.CustomerRecordBtn.Text = "Customer";
            this.CustomerRecordBtn.UseVisualStyleBackColor = true;
            this.CustomerRecordBtn.Click += new System.EventHandler(this.CustomerRecordBtn_Click);
            // 
            // RentalRecordButton
            // 
            this.RentalRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalRecordButton.Location = new System.Drawing.Point(107, 13);
            this.RentalRecordButton.Name = "RentalRecordButton";
            this.RentalRecordButton.Size = new System.Drawing.Size(75, 23);
            this.RentalRecordButton.TabIndex = 2;
            this.RentalRecordButton.Text = "Rental";
            this.RentalRecordButton.UseVisualStyleBackColor = true;
            this.RentalRecordButton.Click += new System.EventHandler(this.RentalRecordButton_Click);
            // 
            // VideosRecordButton
            // 
            this.VideosRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideosRecordButton.Location = new System.Drawing.Point(188, 13);
            this.VideosRecordButton.Name = "VideosRecordButton";
            this.VideosRecordButton.Size = new System.Drawing.Size(77, 23);
            this.VideosRecordButton.TabIndex = 3;
            this.VideosRecordButton.Text = "Videos";
            this.VideosRecordButton.UseVisualStyleBackColor = true;
            this.VideosRecordButton.Click += new System.EventHandler(this.VideosRecordButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delUpdtVideoBox);
            this.groupBox1.Controls.Add(this.UpdateVideoButton);
            this.groupBox1.Controls.Add(this.DeleteVideoButton);
            this.groupBox1.Controls.Add(this.AddVideoButton);
            this.groupBox1.Controls.Add(this.GenreBox);
            this.groupBox1.Controls.Add(this.PlotBox);
            this.groupBox1.Controls.Add(this.CopiesBox);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.YearBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Controls.Add(this.RatingBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(442, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VIDEO DETAILS";
            // 
            // delUpdtVideoBox
            // 
            this.delUpdtVideoBox.AutoSize = true;
            this.delUpdtVideoBox.Location = new System.Drawing.Point(284, 192);
            this.delUpdtVideoBox.Name = "delUpdtVideoBox";
            this.delUpdtVideoBox.Size = new System.Drawing.Size(0, 20);
            this.delUpdtVideoBox.TabIndex = 16;
            this.delUpdtVideoBox.Visible = false;
            // 
            // UpdateVideoButton
            // 
            this.UpdateVideoButton.Location = new System.Drawing.Point(288, 96);
            this.UpdateVideoButton.Name = "UpdateVideoButton";
            this.UpdateVideoButton.Size = new System.Drawing.Size(87, 28);
            this.UpdateVideoButton.TabIndex = 15;
            this.UpdateVideoButton.Text = "UPDATE";
            this.UpdateVideoButton.UseVisualStyleBackColor = true;
            this.UpdateVideoButton.Click += new System.EventHandler(this.UpdateVideoButton_Click);
            // 
            // DeleteVideoButton
            // 
            this.DeleteVideoButton.Location = new System.Drawing.Point(288, 57);
            this.DeleteVideoButton.Name = "DeleteVideoButton";
            this.DeleteVideoButton.Size = new System.Drawing.Size(87, 33);
            this.DeleteVideoButton.TabIndex = 14;
            this.DeleteVideoButton.Text = "DELETE";
            this.DeleteVideoButton.UseVisualStyleBackColor = true;
            this.DeleteVideoButton.Click += new System.EventHandler(this.DeleteVideoButton_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.Location = new System.Drawing.Point(288, 21);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(87, 30);
            this.AddVideoButton.TabIndex = 13;
            this.AddVideoButton.Text = "ADD";
            this.AddVideoButton.UseVisualStyleBackColor = true;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(139, 227);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(100, 26);
            this.GenreBox.TabIndex = 12;
            // 
            // PlotBox
            // 
            this.PlotBox.Location = new System.Drawing.Point(139, 192);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(100, 26);
            this.PlotBox.TabIndex = 11;
            // 
            // CopiesBox
            // 
            this.CopiesBox.Location = new System.Drawing.Point(139, 157);
            this.CopiesBox.Name = "CopiesBox";
            this.CopiesBox.Size = new System.Drawing.Size(100, 26);
            this.CopiesBox.TabIndex = 10;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(139, 122);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 26);
            this.CostBox.TabIndex = 9;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(139, 87);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(100, 26);
            this.YearBox.TabIndex = 8;
            this.YearBox.TextChanged += new System.EventHandler(this.YearBox_TextChanged);
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(139, 52);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(100, 26);
            this.TitleBox.TabIndex = 7;
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(139, 17);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(100, 26);
            this.RatingBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "GENRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "PLOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "COPIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RENTAL COST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "YEAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RATING";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delUpdtCustomerBox);
            this.groupBox2.Controls.Add(this.DeleteCustomerButton);
            this.groupBox2.Controls.Add(this.PhoneBox);
            this.groupBox2.Controls.Add(this.AdressBox);
            this.groupBox2.Controls.Add(this.NameBox);
            this.groupBox2.Controls.Add(this.UpdateCustomerButton);
            this.groupBox2.Controls.Add(this.AddCustomerButton);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 228);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUSTOMER DETAILS";
            // 
            // delUpdtCustomerBox
            // 
            this.delUpdtCustomerBox.AutoSize = true;
            this.delUpdtCustomerBox.Location = new System.Drawing.Point(185, 169);
            this.delUpdtCustomerBox.Name = "delUpdtCustomerBox";
            this.delUpdtCustomerBox.Size = new System.Drawing.Size(0, 20);
            this.delUpdtCustomerBox.TabIndex = 11;
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Location = new System.Drawing.Point(189, 141);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(75, 34);
            this.DeleteCustomerButton.TabIndex = 10;
            this.DeleteCustomerButton.Text = "DELETE";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(111, 70);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(153, 26);
            this.PhoneBox.TabIndex = 9;
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(111, 102);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(153, 26);
            this.AdressBox.TabIndex = 8;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(111, 35);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(153, 26);
            this.NameBox.TabIndex = 6;
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateCustomerButton.Location = new System.Drawing.Point(101, 141);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(84, 34);
            this.UpdateCustomerButton.TabIndex = 5;
            this.UpdateCustomerButton.Text = "Update";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(15, 141);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(75, 34);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "ADD";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "PHONE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = " NAME";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RentalIDBox);
            this.groupBox3.Controls.Add(this.CustomerIDBox);
            this.groupBox3.Controls.Add(this.MovieIDBox);
            this.groupBox3.Controls.Add(this.DeleteRentalButton);
            this.groupBox3.Controls.Add(this.ReturnDateDTP);
            this.groupBox3.Controls.Add(this.DateOfIssueDTP);
            this.groupBox3.Controls.Add(this.ReturnedButton);
            this.groupBox3.Controls.Add(this.IssuedButton);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(349, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 206);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RENTAL VIDEO";
            // 
            // RentalIDBox
            // 
            this.RentalIDBox.AutoSize = true;
            this.RentalIDBox.Location = new System.Drawing.Point(251, 174);
            this.RentalIDBox.Name = "RentalIDBox";
            this.RentalIDBox.Size = new System.Drawing.Size(0, 20);
            this.RentalIDBox.TabIndex = 13;
            this.RentalIDBox.Visible = false;
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.AutoSize = true;
            this.CustomerIDBox.Location = new System.Drawing.Point(134, 44);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(86, 20);
            this.CustomerIDBox.TabIndex = 12;
            this.CustomerIDBox.Text = "Customer ID";
            // 
            // MovieIDBox
            // 
            this.MovieIDBox.AutoSize = true;
            this.MovieIDBox.Location = new System.Drawing.Point(134, 22);
            this.MovieIDBox.Name = "MovieIDBox";
            this.MovieIDBox.Size = new System.Drawing.Size(63, 20);
            this.MovieIDBox.TabIndex = 11;
            this.MovieIDBox.Text = "Movie ID";
            // 
            // DeleteRentalButton
            // 
            this.DeleteRentalButton.Location = new System.Drawing.Point(135, 141);
            this.DeleteRentalButton.Name = "DeleteRentalButton";
            this.DeleteRentalButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteRentalButton.TabIndex = 10;
            this.DeleteRentalButton.Text = "DELETE";
            this.DeleteRentalButton.UseVisualStyleBackColor = true;
            this.DeleteRentalButton.Click += new System.EventHandler(this.DeleteRentalButton_Click);
            // 
            // ReturnDateDTP
            // 
            this.ReturnDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDateDTP.Location = new System.Drawing.Point(138, 102);
            this.ReturnDateDTP.Name = "ReturnDateDTP";
            this.ReturnDateDTP.Size = new System.Drawing.Size(164, 26);
            this.ReturnDateDTP.TabIndex = 9;
            // 
            // DateOfIssueDTP
            // 
            this.DateOfIssueDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfIssueDTP.Location = new System.Drawing.Point(138, 71);
            this.DateOfIssueDTP.Name = "DateOfIssueDTP";
            this.DateOfIssueDTP.Size = new System.Drawing.Size(164, 26);
            this.DateOfIssueDTP.TabIndex = 8;
            // 
            // ReturnedButton
            // 
            this.ReturnedButton.Location = new System.Drawing.Point(217, 141);
            this.ReturnedButton.Name = "ReturnedButton";
            this.ReturnedButton.Size = new System.Drawing.Size(75, 30);
            this.ReturnedButton.TabIndex = 5;
            this.ReturnedButton.Text = "RETURN";
            this.ReturnedButton.UseVisualStyleBackColor = true;
            this.ReturnedButton.Click += new System.EventHandler(this.ReturnedButton_Click);
            // 
            // IssuedButton
            // 
            this.IssuedButton.Location = new System.Drawing.Point(59, 139);
            this.IssuedButton.Name = "IssuedButton";
            this.IssuedButton.Size = new System.Drawing.Size(70, 36);
            this.IssuedButton.TabIndex = 4;
            this.IssuedButton.Text = "ISSUE";
            this.IssuedButton.UseVisualStyleBackColor = true;
            this.IssuedButton.Click += new System.EventHandler(this.IssuedButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "RETURN DATE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "DATE OF ISSUE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "CUSTOMER ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "MOVIE ID";
            // 
            // MostViewedMovieBUtton
            // 
            this.MostViewedMovieBUtton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostViewedMovieBUtton.Location = new System.Drawing.Point(714, 332);
            this.MostViewedMovieBUtton.Name = "MostViewedMovieBUtton";
            this.MostViewedMovieBUtton.Size = new System.Drawing.Size(147, 33);
            this.MostViewedMovieBUtton.TabIndex = 7;
            this.MostViewedMovieBUtton.Text = "MOST VIEWED MOVIES";
            this.MostViewedMovieBUtton.UseVisualStyleBackColor = true;
            this.MostViewedMovieBUtton.Click += new System.EventHandler(this.MostViewedMovieBUtton_Click);
            // 
            // MostRatedCustomerButton
            // 
            this.MostRatedCustomerButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostRatedCustomerButton.Location = new System.Drawing.Point(714, 381);
            this.MostRatedCustomerButton.Name = "MostRatedCustomerButton";
            this.MostRatedCustomerButton.Size = new System.Drawing.Size(147, 38);
            this.MostRatedCustomerButton.TabIndex = 8;
            this.MostRatedCustomerButton.Text = "CUSTOMER RANKING";
            this.MostRatedCustomerButton.UseVisualStyleBackColor = true;
            this.MostRatedCustomerButton.Click += new System.EventHandler(this.MostRatedCustomerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(714, 436);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(147, 36);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(873, 541);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MostRatedCustomerButton);
            this.Controls.Add(this.MostViewedMovieBUtton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VideosRecordButton);
            this.Controls.Add(this.RentalRecordButton);
            this.Controls.Add(this.CustomerRecordBtn);
            this.Controls.Add(this.RecordBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordBox;
        private System.Windows.Forms.Button CustomerRecordBtn;
        private System.Windows.Forms.Button RentalRecordButton;
        private System.Windows.Forms.Button VideosRecordButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateVideoButton;
        private System.Windows.Forms.Button DeleteVideoButton;
        private System.Windows.Forms.Button AddVideoButton;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox PlotBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox RatingBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteRentalButton;
        private System.Windows.Forms.DateTimePicker ReturnDateDTP;
        private System.Windows.Forms.DateTimePicker DateOfIssueDTP;
        private System.Windows.Forms.Button ReturnedButton;
        private System.Windows.Forms.Button IssuedButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button MostViewedMovieBUtton;
        private System.Windows.Forms.Button MostRatedCustomerButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox CopiesBox;
        private System.Windows.Forms.Label MovieIDBox;
        private System.Windows.Forms.Label CustomerIDBox;
        private System.Windows.Forms.Label delUpdtCustomerBox;
        private System.Windows.Forms.Label delUpdtVideoBox;
        private System.Windows.Forms.Label RentalIDBox;
    }
}

