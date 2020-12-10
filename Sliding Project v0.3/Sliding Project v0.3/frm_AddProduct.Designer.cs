namespace Sliding_Project_v0._3
{
    partial class frm_AddProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Catagory = new System.Windows.Forms.ComboBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OtherSelectAll = new System.Windows.Forms.Button();
            this.btn_WindowsSelectAll = new System.Windows.Forms.Button();
            this.btn_GlassSelectAll = new System.Windows.Forms.Button();
            this.clb_Window = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clb_Glass = new System.Windows.Forms.CheckedListBox();
            this.clb_Other = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.rb_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_RequiredTimeToBuild = new System.Windows.Forms.ComboBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(953, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(1002, 70);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add Product";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 70);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(7, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 108);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.965219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.74046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.62807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.74046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.62807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.297729F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Catagory, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 45);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(260, 8);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(215, 29);
            this.tb_Name.TabIndex = 16;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(93, 3);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(132, 38);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "NAME";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Catagory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Catagory
            // 
            this.cmb_Catagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Catagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catagory.FormattingEnabled = true;
            this.cmb_Catagory.Items.AddRange(new object[] {
            "Window",
            "Door"});
            this.cmb_Catagory.Location = new System.Drawing.Point(680, 6);
            this.cmb_Catagory.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Catagory.Name = "cmb_Catagory";
            this.cmb_Catagory.Size = new System.Drawing.Size(215, 33);
            this.cmb_Catagory.TabIndex = 18;
            this.cmb_Catagory.SelectedIndexChanged += new System.EventHandler(this.cmb_Catagory_SelectedIndexChanged);
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(429, 20);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(222, 29);
            this.tb_ID.TabIndex = 18;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(302, 14);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(96, 32);
            this.lbl_ID.TabIndex = 17;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(672, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(131, 29);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882355F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882354F));
            this.tableLayoutPanel4.Controls.Add(this.btn_OtherSelectAll, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_WindowsSelectAll, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_GlassSelectAll, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.clb_Window, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.clb_Glass, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.clb_Other, 3, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46171F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.28304F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25525F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(971, 213);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // btn_OtherSelectAll
            // 
            this.btn_OtherSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OtherSelectAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OtherSelectAll.FlatAppearance.BorderSize = 0;
            this.btn_OtherSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OtherSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OtherSelectAll.Location = new System.Drawing.Point(687, 190);
            this.btn_OtherSelectAll.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.btn_OtherSelectAll.Name = "btn_OtherSelectAll";
            this.btn_OtherSelectAll.Size = new System.Drawing.Size(165, 23);
            this.btn_OtherSelectAll.TabIndex = 39;
            this.btn_OtherSelectAll.Text = "Select All";
            this.btn_OtherSelectAll.UseVisualStyleBackColor = false;
            this.btn_OtherSelectAll.Click += new System.EventHandler(this.btn_OtherSelectAll_Click);
            // 
            // btn_WindowsSelectAll
            // 
            this.btn_WindowsSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WindowsSelectAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_WindowsSelectAll.FlatAppearance.BorderSize = 0;
            this.btn_WindowsSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WindowsSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WindowsSelectAll.Location = new System.Drawing.Point(117, 190);
            this.btn_WindowsSelectAll.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.btn_WindowsSelectAll.Name = "btn_WindowsSelectAll";
            this.btn_WindowsSelectAll.Size = new System.Drawing.Size(165, 23);
            this.btn_WindowsSelectAll.TabIndex = 37;
            this.btn_WindowsSelectAll.Text = "Select All";
            this.btn_WindowsSelectAll.UseVisualStyleBackColor = false;
            this.btn_WindowsSelectAll.Click += new System.EventHandler(this.btn_WindowsSelectAll_Click);
            // 
            // btn_GlassSelectAll
            // 
            this.btn_GlassSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GlassSelectAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GlassSelectAll.FlatAppearance.BorderSize = 0;
            this.btn_GlassSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GlassSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GlassSelectAll.Location = new System.Drawing.Point(402, 190);
            this.btn_GlassSelectAll.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.btn_GlassSelectAll.Name = "btn_GlassSelectAll";
            this.btn_GlassSelectAll.Size = new System.Drawing.Size(165, 23);
            this.btn_GlassSelectAll.TabIndex = 38;
            this.btn_GlassSelectAll.Text = "Select All";
            this.btn_GlassSelectAll.UseVisualStyleBackColor = false;
            this.btn_GlassSelectAll.Click += new System.EventHandler(this.btn_GlassSelectAll_Click);
            // 
            // clb_Window
            // 
            this.clb_Window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Window.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Window.FormattingEnabled = true;
            this.clb_Window.Location = new System.Drawing.Point(69, 36);
            this.clb_Window.Margin = new System.Windows.Forms.Padding(12, 8, 12, 3);
            this.clb_Window.Name = "clb_Window";
            this.clb_Window.Size = new System.Drawing.Size(261, 151);
            this.clb_Window.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Select Required Material";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clb_Glass
            // 
            this.clb_Glass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Glass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Glass.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Glass.FormattingEnabled = true;
            this.clb_Glass.Location = new System.Drawing.Point(354, 36);
            this.clb_Glass.Margin = new System.Windows.Forms.Padding(12, 8, 12, 3);
            this.clb_Glass.Name = "clb_Glass";
            this.clb_Glass.Size = new System.Drawing.Size(261, 151);
            this.clb_Glass.TabIndex = 35;
            // 
            // clb_Other
            // 
            this.clb_Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Other.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Other.FormattingEnabled = true;
            this.clb_Other.Location = new System.Drawing.Point(639, 36);
            this.clb_Other.Margin = new System.Windows.Forms.Padding(12, 8, 12, 3);
            this.clb_Other.Name = "clb_Other";
            this.clb_Other.Size = new System.Drawing.Size(261, 151);
            this.clb_Other.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(7, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 240);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(7, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(983, 224);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Details";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.380952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.380952F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.pb_Image, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Price, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Upload, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_RequiredTimeToBuild, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Description, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.3203F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.3203F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.35939F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(971, 201);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 38);
            this.label8.TabIndex = 31;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Image
            // 
            this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Image.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pb_Image.Location = new System.Drawing.Point(726, 130);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(10);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(211, 61);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 31;
            this.pb_Image.TabStop = false;
            // 
            // tb_Price
            // 
            this.tb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(264, 15);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(211, 29);
            this.tb_Price.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.rb_No);
            this.panel2.Controls.Add(this.rb_Yes);
            this.panel2.Location = new System.Drawing.Point(264, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 29);
            this.panel2.TabIndex = 33;
            // 
            // rb_No
            // 
            this.rb_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_No.Location = new System.Drawing.Point(123, 2);
            this.rb_No.Name = "rb_No";
            this.rb_No.Size = new System.Drawing.Size(72, 24);
            this.rb_No.TabIndex = 1;
            this.rb_No.TabStop = true;
            this.rb_No.Text = "NO";
            this.rb_No.UseVisualStyleBackColor = true;
            // 
            // rb_Yes
            // 
            this.rb_Yes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Yes.Location = new System.Drawing.Point(21, 3);
            this.rb_Yes.Name = "rb_Yes";
            this.rb_Yes.Size = new System.Drawing.Size(72, 24);
            this.rb_Yes.TabIndex = 0;
            this.rb_Yes.TabStop = true;
            this.rb_Yes.Text = "YES";
            this.rb_Yes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "Available In Tracks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Upload.FlatAppearance.BorderSize = 0;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(726, 66);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(211, 29);
            this.btn_Upload.TabIndex = 29;
            this.btn_Upload.Text = "UPLOAD";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 38);
            this.label7.TabIndex = 30;
            this.label7.Text = "Image";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price By SQFT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Required Time To Build";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_RequiredTimeToBuild
            // 
            this.cmb_RequiredTimeToBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_RequiredTimeToBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_RequiredTimeToBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RequiredTimeToBuild.FormattingEnabled = true;
            this.cmb_RequiredTimeToBuild.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmb_RequiredTimeToBuild.Location = new System.Drawing.Point(728, 13);
            this.cmb_RequiredTimeToBuild.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_RequiredTimeToBuild.Name = "cmb_RequiredTimeToBuild";
            this.cmb_RequiredTimeToBuild.Size = new System.Drawing.Size(207, 33);
            this.cmb_RequiredTimeToBuild.TabIndex = 18;
            // 
            // tb_Description
            // 
            this.tb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Description.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(264, 125);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(211, 29);
            this.tb_Description.TabIndex = 34;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(666, 666);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(144, 35);
            this.btn_Add.TabIndex = 36;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(199, 666);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(144, 35);
            this.btn_Refresh.TabIndex = 35;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frm_AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Catagory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_RequiredTimeToBuild;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clb_Window;
        private System.Windows.Forms.CheckedListBox clb_Glass;
        private System.Windows.Forms.CheckedListBox clb_Other;
        private System.Windows.Forms.Button btn_OtherSelectAll;
        private System.Windows.Forms.Button btn_WindowsSelectAll;
        private System.Windows.Forms.Button btn_GlassSelectAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_No;
        private System.Windows.Forms.RadioButton rb_Yes;
        private System.Windows.Forms.TextBox tb_Description;
    }
}