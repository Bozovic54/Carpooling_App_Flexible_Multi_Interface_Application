namespace CarpoolingApp
{
    partial class Carpooling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carpooling));
            this.header = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.numericSeats = new System.Windows.Forms.NumericUpDown();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureSeats = new System.Windows.Forms.PictureBox();
            this.pictureDate = new System.Windows.Forms.PictureBox();
            this.txtEndLocation = new System.Windows.Forms.TextBox();
            this.pictureEndLocation = new System.Windows.Forms.PictureBox();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.pictureStartLocation = new System.Windows.Forms.PictureBox();
            this.newRideLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRides = new System.Windows.Forms.Panel();
            this.btnTimeDSC = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnTimeASC = new System.Windows.Forms.RadioButton();
            this.btnPriceDSC = new System.Windows.Forms.RadioButton();
            this.btnPriceASC = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnTimeMorning = new System.Windows.Forms.RadioButton();
            this.btnTimeNoon = new System.Windows.Forms.RadioButton();
            this.btnTimeNight = new System.Windows.Forms.RadioButton();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxSort = new System.Windows.Forms.GroupBox();
            this.gboxFilter = new System.Windows.Forms.GroupBox();
            this.header.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEndLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStartLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlWelcome.SuspendLayout();
            this.gboxSort.SuspendLayout();
            this.gboxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Controls.Add(this.SearchPanel);
            this.header.Controls.Add(this.newRideLink);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.Logo);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(0, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1908, 203);
            this.header.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchPanel.Controls.Add(this.btnSearch);
            this.SearchPanel.Controls.Add(this.numericSeats);
            this.SearchPanel.Controls.Add(this.DatePicker);
            this.SearchPanel.Controls.Add(this.pictureSeats);
            this.SearchPanel.Controls.Add(this.pictureDate);
            this.SearchPanel.Controls.Add(this.txtEndLocation);
            this.SearchPanel.Controls.Add(this.pictureEndLocation);
            this.SearchPanel.Controls.Add(this.txtStartLocation);
            this.SearchPanel.Controls.Add(this.pictureStartLocation);
            this.SearchPanel.Location = new System.Drawing.Point(423, 97);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1150, 71);
            this.SearchPanel.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(1020, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 67);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // numericSeats
            // 
            this.numericSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.numericSeats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericSeats.Location = new System.Drawing.Point(899, 19);
            this.numericSeats.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSeats.Name = "numericSeats";
            this.numericSeats.Size = new System.Drawing.Size(38, 30);
            this.numericSeats.TabIndex = 1;
            this.numericSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarForeColor = System.Drawing.Color.White;
            this.DatePicker.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.DatePicker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.DatePicker.CalendarTrailingForeColor = System.Drawing.Color.GhostWhite;
            this.DatePicker.CausesValidation = false;
            this.DatePicker.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(601, 21);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.MinDate = new System.DateTime(2020, 11, 14, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShowUpDown = true;
            this.DatePicker.Size = new System.Drawing.Size(126, 29);
            this.DatePicker.TabIndex = 1;
            // 
            // pictureSeats
            // 
            this.pictureSeats.Image = ((System.Drawing.Image)(resources.GetObject("pictureSeats.Image")));
            this.pictureSeats.Location = new System.Drawing.Point(840, 9);
            this.pictureSeats.Name = "pictureSeats";
            this.pictureSeats.Size = new System.Drawing.Size(53, 55);
            this.pictureSeats.TabIndex = 5;
            this.pictureSeats.TabStop = false;
            // 
            // pictureDate
            // 
            this.pictureDate.Image = ((System.Drawing.Image)(resources.GetObject("pictureDate.Image")));
            this.pictureDate.Location = new System.Drawing.Point(541, 9);
            this.pictureDate.Name = "pictureDate";
            this.pictureDate.Size = new System.Drawing.Size(53, 55);
            this.pictureDate.TabIndex = 4;
            this.pictureDate.TabStop = false;
            // 
            // txtEndLocation
            // 
            this.txtEndLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Beograd",
            "Novi Sad",
            "Niš",
            "Kragujevac",
            "Subotica",
            "Zrenjanin",
            "Čačak",
            "Kraljevo",
            "Leskovac",
            "Zaječar",
            "Zlatibor",
            "Pančevo"});
            this.txtEndLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEndLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEndLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtEndLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEndLocation.Location = new System.Drawing.Point(353, 25);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(100, 19);
            this.txtEndLocation.TabIndex = 3;
            // 
            // pictureEndLocation
            // 
            this.pictureEndLocation.Image = ((System.Drawing.Image)(resources.GetObject("pictureEndLocation.Image")));
            this.pictureEndLocation.Location = new System.Drawing.Point(294, 9);
            this.pictureEndLocation.Name = "pictureEndLocation";
            this.pictureEndLocation.Size = new System.Drawing.Size(53, 55);
            this.pictureEndLocation.TabIndex = 2;
            this.pictureEndLocation.TabStop = false;
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Beograd",
            "Novi Sad",
            "Niš",
            "Kragujevac",
            "Subotica",
            "Zrenjanin",
            "Čačak",
            "Kraljevo",
            "Leskovac",
            "Zaječar",
            "Zlatibor",
            "Pančevo"});
            this.txtStartLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStartLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStartLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtStartLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStartLocation.Location = new System.Drawing.Point(102, 25);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(100, 19);
            this.txtStartLocation.TabIndex = 1;
            // 
            // pictureStartLocation
            // 
            this.pictureStartLocation.Image = ((System.Drawing.Image)(resources.GetObject("pictureStartLocation.Image")));
            this.pictureStartLocation.Location = new System.Drawing.Point(43, 9);
            this.pictureStartLocation.Name = "pictureStartLocation";
            this.pictureStartLocation.Size = new System.Drawing.Size(53, 55);
            this.pictureStartLocation.TabIndex = 0;
            this.pictureStartLocation.TabStop = false;
            // 
            // newRideLink
            // 
            this.newRideLink.AutoSize = true;
            this.newRideLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.newRideLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.newRideLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.newRideLink.Location = new System.Drawing.Point(1623, 35);
            this.newRideLink.Name = "newRideLink";
            this.newRideLink.Size = new System.Drawing.Size(161, 26);
            this.newRideLink.TabIndex = 3;
            this.newRideLink.TabStop = true;
            this.newRideLink.Text = "Objavite vožnju";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1582, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 56);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.Logo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Logo.LinkColor = System.Drawing.Color.SteelBlue;
            this.Logo.Location = new System.Drawing.Point(300, 35);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(123, 26);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = true;
            this.Logo.Text = "Carpooling ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRides
            // 
            this.pnlRides.AutoScroll = true;
            this.pnlRides.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRides.Location = new System.Drawing.Point(1100, 256);
            this.pnlRides.Name = "pnlRides";
            this.pnlRides.Size = new System.Drawing.Size(567, 593);
            this.pnlRides.TabIndex = 5;
            // 
            // btnTimeDSC
            // 
            this.btnTimeDSC.AutoSize = true;
            this.btnTimeDSC.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeDSC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeDSC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnTimeDSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeDSC.Location = new System.Drawing.Point(19, 70);
            this.btnTimeDSC.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeDSC.Name = "btnTimeDSC";
            this.btnTimeDSC.Size = new System.Drawing.Size(237, 28);
            this.btnTimeDSC.TabIndex = 7;
            this.btnTimeDSC.TabStop = true;
            this.btnTimeDSC.Text = "Najranije vreme polaska";
            this.btnTimeDSC.UseVisualStyleBackColor = false;
            this.btnTimeDSC.Click += new System.EventHandler(this.SortRides);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.SystemColors.Control;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.4F, System.Drawing.FontStyle.Bold);
            this.lblSort.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSort.Location = new System.Drawing.Point(6, 18);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(171, 29);
            this.lblSort.TabIndex = 8;
            this.lblSort.Text = "Poređajte po:";
            // 
            // btnTimeASC
            // 
            this.btnTimeASC.AutoSize = true;
            this.btnTimeASC.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeASC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeASC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnTimeASC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeASC.Location = new System.Drawing.Point(19, 121);
            this.btnTimeASC.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeASC.Name = "btnTimeASC";
            this.btnTimeASC.Size = new System.Drawing.Size(248, 28);
            this.btnTimeASC.TabIndex = 9;
            this.btnTimeASC.TabStop = true;
            this.btnTimeASC.Text = "Najkasnije vreme polaska";
            this.btnTimeASC.UseVisualStyleBackColor = false;
            this.btnTimeASC.Click += new System.EventHandler(this.SortRides);
            // 
            // btnPriceDSC
            // 
            this.btnPriceDSC.AutoSize = true;
            this.btnPriceDSC.BackColor = System.Drawing.Color.Transparent;
            this.btnPriceDSC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPriceDSC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnPriceDSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPriceDSC.Location = new System.Drawing.Point(19, 174);
            this.btnPriceDSC.Margin = new System.Windows.Forms.Padding(5);
            this.btnPriceDSC.Name = "btnPriceDSC";
            this.btnPriceDSC.Size = new System.Drawing.Size(140, 28);
            this.btnPriceDSC.TabIndex = 10;
            this.btnPriceDSC.TabStop = true;
            this.btnPriceDSC.Text = "Najniža cena";
            this.btnPriceDSC.UseVisualStyleBackColor = false;
            this.btnPriceDSC.Click += new System.EventHandler(this.SortRides);
            // 
            // btnPriceASC
            // 
            this.btnPriceASC.AutoSize = true;
            this.btnPriceASC.BackColor = System.Drawing.Color.Transparent;
            this.btnPriceASC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPriceASC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnPriceASC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPriceASC.Location = new System.Drawing.Point(19, 223);
            this.btnPriceASC.Margin = new System.Windows.Forms.Padding(5);
            this.btnPriceASC.Name = "btnPriceASC";
            this.btnPriceASC.Size = new System.Drawing.Size(137, 28);
            this.btnPriceASC.TabIndex = 11;
            this.btnPriceASC.TabStop = true;
            this.btnPriceASC.Text = "Najviša cena";
            this.btnPriceASC.UseVisualStyleBackColor = false;
            this.btnPriceASC.Click += new System.EventHandler(this.SortRides);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.SystemColors.Control;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.4F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFilter.Location = new System.Drawing.Point(6, 27);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(194, 29);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Vreme polaska:";
            // 
            // btnTimeMorning
            // 
            this.btnTimeMorning.AutoSize = true;
            this.btnTimeMorning.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeMorning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeMorning.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnTimeMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeMorning.Location = new System.Drawing.Point(19, 81);
            this.btnTimeMorning.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeMorning.Name = "btnTimeMorning";
            this.btnTimeMorning.Size = new System.Drawing.Size(144, 28);
            this.btnTimeMorning.TabIndex = 13;
            this.btnTimeMorning.TabStop = true;
            this.btnTimeMorning.Text = "06:00 - 12:00";
            this.btnTimeMorning.UseVisualStyleBackColor = false;
            this.btnTimeMorning.CheckedChanged += new System.EventHandler(this.FilterRides);
            // 
            // btnTimeNoon
            // 
            this.btnTimeNoon.AutoSize = true;
            this.btnTimeNoon.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeNoon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeNoon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnTimeNoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeNoon.Location = new System.Drawing.Point(19, 135);
            this.btnTimeNoon.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeNoon.Name = "btnTimeNoon";
            this.btnTimeNoon.Size = new System.Drawing.Size(144, 28);
            this.btnTimeNoon.TabIndex = 14;
            this.btnTimeNoon.TabStop = true;
            this.btnTimeNoon.Text = "12:00 - 18:00";
            this.btnTimeNoon.UseVisualStyleBackColor = false;
            this.btnTimeNoon.CheckedChanged += new System.EventHandler(this.FilterRides);
            // 
            // btnTimeNight
            // 
            this.btnTimeNight.AutoSize = true;
            this.btnTimeNight.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeNight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimeNight.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.4F);
            this.btnTimeNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeNight.Location = new System.Drawing.Point(19, 188);
            this.btnTimeNight.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeNight.Name = "btnTimeNight";
            this.btnTimeNight.Size = new System.Drawing.Size(133, 28);
            this.btnTimeNight.TabIndex = 15;
            this.btnTimeNight.TabStop = true;
            this.btnTimeNight.Text = "Posle 18:00 ";
            this.btnTimeNight.UseVisualStyleBackColor = false;
            this.btnTimeNight.CheckedChanged += new System.EventHandler(this.FilterRides);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlWelcome.Controls.Add(this.btnStartSearch);
            this.pnlWelcome.Controls.Add(this.label2);
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Location = new System.Drawing.Point(602, 256);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(831, 297);
            this.pnlWelcome.TabIndex = 18;
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartSearch.ForeColor = System.Drawing.Color.White;
            this.btnStartSearch.Location = new System.Drawing.Point(0, 223);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(831, 74);
            this.btnStartSearch.TabIndex = 2;
            this.btnStartSearch.Text = "Počnite pretragu";
            this.btnStartSearch.UseVisualStyleBackColor = false;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(114, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 102);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planirajte svoje putovanje uz samo nekoliko klikova! Unesite detalje pretrage i o" +
    "tkrijte vožnje koje savršeno odgovaraju vašim potrebama i željama.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(153, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u Carpooling aplikaciju!";
            // 
            // gboxSort
            // 
            this.gboxSort.Controls.Add(this.btnTimeDSC);
            this.gboxSort.Controls.Add(this.btnTimeASC);
            this.gboxSort.Controls.Add(this.btnPriceDSC);
            this.gboxSort.Controls.Add(this.btnPriceASC);
            this.gboxSort.Controls.Add(this.lblSort);
            this.gboxSort.Location = new System.Drawing.Point(602, 256);
            this.gboxSort.Name = "gboxSort";
            this.gboxSort.Size = new System.Drawing.Size(276, 285);
            this.gboxSort.TabIndex = 19;
            this.gboxSort.TabStop = false;
            this.gboxSort.Visible = false;
            this.gboxSort.Paint += new System.Windows.Forms.PaintEventHandler(this.gbox_Paint);
            // 
            // gboxFilter
            // 
            this.gboxFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gboxFilter.Controls.Add(this.btnTimeNight);
            this.gboxFilter.Controls.Add(this.lblFilter);
            this.gboxFilter.Controls.Add(this.btnTimeNoon);
            this.gboxFilter.Controls.Add(this.btnTimeMorning);
            this.gboxFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.gboxFilter.Location = new System.Drawing.Point(602, 538);
            this.gboxFilter.Name = "gboxFilter";
            this.gboxFilter.Size = new System.Drawing.Size(276, 292);
            this.gboxFilter.TabIndex = 20;
            this.gboxFilter.TabStop = false;
            this.gboxFilter.Visible = false;
            this.gboxFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.gbox_Paint);
            // 
            // Carpooling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 861);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.gboxFilter);
            this.Controls.Add(this.gboxSort);
            this.Controls.Add(this.pnlRides);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carpooling";
            this.Text = "CarpoolingApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEndLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStartLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.gboxSort.ResumeLayout(false);
            this.gboxSort.PerformLayout();
            this.gboxFilter.ResumeLayout(false);
            this.gboxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Logo;
        private System.Windows.Forms.LinkLabel newRideLink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.PictureBox pictureStartLocation;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.PictureBox pictureEndLocation;
        private System.Windows.Forms.TextBox txtEndLocation;
        private System.Windows.Forms.PictureBox pictureDate;
        private System.Windows.Forms.PictureBox pictureSeats;
        private System.Windows.Forms.NumericUpDown numericSeats;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlRides;
        private System.Windows.Forms.RadioButton btnTimeDSC;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton btnTimeASC;
        private System.Windows.Forms.RadioButton btnPriceDSC;
        private System.Windows.Forms.RadioButton btnPriceASC;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.RadioButton btnTimeMorning;
        private System.Windows.Forms.RadioButton btnTimeNoon;
        private System.Windows.Forms.RadioButton btnTimeNight;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.GroupBox gboxSort;
        private System.Windows.Forms.GroupBox gboxFilter;
    }
}

