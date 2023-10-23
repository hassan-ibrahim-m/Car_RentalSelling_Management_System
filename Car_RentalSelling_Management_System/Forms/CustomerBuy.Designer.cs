namespace Car_RentalSelling_Management_System
{
    partial class CustomerBuyOld
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
            this.db_MinYear = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.db_MinCost = new System.Windows.Forms.ComboBox();
            this.db_MaxCost = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.db_MaxYear = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.db_FuelType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.db_type = new System.Windows.Forms.ComboBox();
            this.lv_buy = new System.Windows.Forms.ListView();
            this.Manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Car_Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FuleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.db_CarModel = new System.Windows.Forms.ComboBox();
            this.db_Manufacturer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_apply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_MinYear
            // 
            this.db_MinYear.BackColor = System.Drawing.Color.LightGray;
            this.db_MinYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_MinYear.FormattingEnabled = true;
            this.db_MinYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.db_MinYear.Location = new System.Drawing.Point(28, 56);
            this.db_MinYear.Margin = new System.Windows.Forms.Padding(4);
            this.db_MinYear.Name = "db_MinYear";
            this.db_MinYear.Size = new System.Drawing.Size(93, 24);
            this.db_MinYear.TabIndex = 29;
            this.db_MinYear.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.db_MinCost);
            this.panel2.Controls.Add(this.db_MaxCost);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(530, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 164);
            this.panel2.TabIndex = 42;
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.AutoArrange = false;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader12});
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-79, 187);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Scrollable = false;
            this.listView2.Size = new System.Drawing.Size(548, 217);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Car Model";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Car Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rating";
            this.columnHeader3.Width = 59;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cost";
            this.columnHeader9.Width = 69;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rate";
            // 
            // db_MinCost
            // 
            this.db_MinCost.BackColor = System.Drawing.Color.LightGray;
            this.db_MinCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_MinCost.FormattingEnabled = true;
            this.db_MinCost.ItemHeight = 24;
            this.db_MinCost.Items.AddRange(new object[] {
            "0",
            "100000",
            "200000",
            "300000",
            "400000",
            "500000"});
            this.db_MinCost.Location = new System.Drawing.Point(25, 51);
            this.db_MinCost.Margin = new System.Windows.Forms.Padding(4);
            this.db_MinCost.Name = "db_MinCost";
            this.db_MinCost.Size = new System.Drawing.Size(93, 32);
            this.db_MinCost.TabIndex = 29;
            // 
            // db_MaxCost
            // 
            this.db_MaxCost.BackColor = System.Drawing.Color.LightGray;
            this.db_MaxCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_MaxCost.FormattingEnabled = true;
            this.db_MaxCost.ItemHeight = 24;
            this.db_MaxCost.Items.AddRange(new object[] {
            "100000",
            "200000",
            "300000",
            "400000",
            "500000",
            "1000000",
            "2000000",
            "3000000",
            "4000000",
            "5000000",
            "10000000"});
            this.db_MaxCost.Location = new System.Drawing.Point(25, 120);
            this.db_MaxCost.Margin = new System.Windows.Forms.Padding(4);
            this.db_MaxCost.Name = "db_MaxCost";
            this.db_MaxCost.Size = new System.Drawing.Size(93, 32);
            this.db_MaxCost.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Max ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "Min ";
            // 
            // db_MaxYear
            // 
            this.db_MaxYear.BackColor = System.Drawing.Color.LightGray;
            this.db_MaxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_MaxYear.FormattingEnabled = true;
            this.db_MaxYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.db_MaxYear.Location = new System.Drawing.Point(28, 125);
            this.db_MaxYear.Margin = new System.Windows.Forms.Padding(4);
            this.db_MaxYear.Name = "db_MaxYear";
            this.db_MaxYear.Size = new System.Drawing.Size(93, 24);
            this.db_MaxYear.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.db_MinYear);
            this.panel1.Controls.Add(this.db_MaxYear);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(297, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 164);
            this.panel1.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Max ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Min ";
            // 
            // db_FuelType
            // 
            this.db_FuelType.BackColor = System.Drawing.Color.LightGray;
            this.db_FuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_FuelType.FormattingEnabled = true;
            this.db_FuelType.Items.AddRange(new object[] {
            "ELECTRIC",
            "GASOLINE",
            "HYBRID",
            "DIESEL"});
            this.db_FuelType.Location = new System.Drawing.Point(751, 157);
            this.db_FuelType.Margin = new System.Windows.Forms.Padding(4);
            this.db_FuelType.Name = "db_FuelType";
            this.db_FuelType.Size = new System.Drawing.Size(155, 24);
            this.db_FuelType.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(748, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(748, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // db_type
            // 
            this.db_type.BackColor = System.Drawing.Color.LightGray;
            this.db_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_type.FormattingEnabled = true;
            this.db_type.Items.AddRange(new object[] {
            "SUV",
            "Car",
            "Truck",
            "Minivan",
            "Van"});
            this.db_type.Location = new System.Drawing.Point(751, 85);
            this.db_type.Margin = new System.Windows.Forms.Padding(4);
            this.db_type.Name = "db_type";
            this.db_type.Size = new System.Drawing.Size(155, 24);
            this.db_type.TabIndex = 33;
            this.db_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lv_buy
            // 
            this.lv_buy.AllowDrop = true;
            this.lv_buy.AutoArrange = false;
            this.lv_buy.BackColor = System.Drawing.Color.LightGray;
            this.lv_buy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Manufacturer,
            this.Car_Model,
            this.FuleType,
            this.Year,
            this.City,
            this.KM,
            this.Rating,
            this.Price,
            this.Cost,
            this.columnHeader5});
            this.lv_buy.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.lv_buy.FullRowSelect = true;
            this.lv_buy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_buy.HideSelection = false;
            this.lv_buy.HoverSelection = true;
            this.lv_buy.Location = new System.Drawing.Point(36, 251);
            this.lv_buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_buy.MultiSelect = false;
            this.lv_buy.Name = "lv_buy";
            this.lv_buy.Scrollable = false;
            this.lv_buy.Size = new System.Drawing.Size(1113, 267);
            this.lv_buy.TabIndex = 32;
            this.lv_buy.UseCompatibleStateImageBehavior = false;
            this.lv_buy.View = System.Windows.Forms.View.Details;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Text = "Manufacturer";
            this.Manufacturer.Width = 120;
            // 
            // Car_Model
            // 
            this.Car_Model.DisplayIndex = 2;
            this.Car_Model.Text = "Car Model";
            this.Car_Model.Width = 100;
            // 
            // FuleType
            // 
            this.FuleType.DisplayIndex = 8;
            this.FuleType.Text = "Fule Type";
            this.FuleType.Width = 100;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 100;
            // 
            // City
            // 
            this.City.DisplayIndex = 6;
            this.City.Text = "City";
            this.City.Width = 100;
            // 
            // KM
            // 
            this.KM.Text = "KM";
            this.KM.Width = 100;
            // 
            // Rating
            // 
            this.Rating.DisplayIndex = 1;
            this.Rating.Text = "Rating";
            this.Rating.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Cost
            // 
            this.Cost.DisplayIndex = 4;
            this.Cost.Text = "Cost";
            this.Cost.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Car Type";
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Model";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.bt_cancel.Location = new System.Drawing.Point(761, 537);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(240, 53);
            this.bt_cancel.TabIndex = 46;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.bt_submit.Location = new System.Drawing.Point(269, 537);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(240, 53);
            this.bt_submit.TabIndex = 45;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // db_CarModel
            // 
            this.db_CarModel.BackColor = System.Drawing.Color.LightGray;
            this.db_CarModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_CarModel.FormattingEnabled = true;
            this.db_CarModel.Location = new System.Drawing.Point(36, 157);
            this.db_CarModel.Margin = new System.Windows.Forms.Padding(4);
            this.db_CarModel.Name = "db_CarModel";
            this.db_CarModel.Size = new System.Drawing.Size(199, 24);
            this.db_CarModel.TabIndex = 55;
            this.db_CarModel.SelectedIndexChanged += new System.EventHandler(this.db_CarModel_SelectedIndexChanged);
            // 
            // db_Manufacturer
            // 
            this.db_Manufacturer.BackColor = System.Drawing.Color.LightGray;
            this.db_Manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.db_Manufacturer.FormattingEnabled = true;
            this.db_Manufacturer.Items.AddRange(new object[] {
            "Acura",
            "Alfa Romeo",
            "Alfa-romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Ferrari",
            "FIAT",
            "Ford",
            "Genesis",
            "GMC",
            "Honda",
            "HUMMER",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Maserati",
            "Mazda",
            "McLaren",
            "Mercedes-Benz",
            "Mercury",
            "MINI",
            "Mitsubishi",
            "Nissan",
            "Polaris",
            "Pontiac",
            "Porsche",
            "Ram",
            "Rolls Royce",
            "Saab",
            "Saturn",
            "Scion",
            "smart",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.db_Manufacturer.Location = new System.Drawing.Point(32, 85);
            this.db_Manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.db_Manufacturer.Name = "db_Manufacturer";
            this.db_Manufacturer.Size = new System.Drawing.Size(199, 24);
            this.db_Manufacturer.TabIndex = 53;
            this.db_Manufacturer.SelectedIndexChanged += new System.EventHandler(this.db_Manufacturer_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Manufacturer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bt_apply
            // 
            this.bt_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.bt_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_apply.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.bt_apply.Location = new System.Drawing.Point(1003, 29);
            this.bt_apply.Margin = new System.Windows.Forms.Padding(4);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(156, 62);
            this.bt_apply.TabIndex = 57;
            this.bt_apply.Text = "Apply";
            this.bt_apply.UseVisualStyleBackColor = false;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.button1.Location = new System.Drawing.Point(1003, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 62);
            this.button1.TabIndex = 58;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerBuyOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1182, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.db_CarModel);
            this.Controls.Add(this.db_Manufacturer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.db_FuelType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.db_type);
            this.Controls.Add(this.lv_buy);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerBuyOld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerBuy";
            this.Load += new System.EventHandler(this.CustomerBuy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox db_MinYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ComboBox db_MaxCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox db_MaxYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox db_FuelType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox db_type;
        private System.Windows.Forms.ListView lv_buy;
        private System.Windows.Forms.ColumnHeader Car_Model;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader KM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Manufacturer;
        private System.Windows.Forms.ColumnHeader FuleType;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.ComboBox db_CarModel;
        private System.Windows.Forms.ComboBox db_Manufacturer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox db_MinCost;
        private System.Windows.Forms.Button button1;
    }
}