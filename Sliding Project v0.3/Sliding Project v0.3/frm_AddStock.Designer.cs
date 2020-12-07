namespace Sliding_Project_v0._3
{
    partial class frm_AddStock
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Distributor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Material = new System.Windows.Forms.ComboBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Remove = new System.Windows.Forms.DataGridView();
            this.dgv_StockItems = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Paid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.cmb_Colour = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.cmb_Track = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_SubCatagory = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_AvailableStock = new System.Windows.Forms.TextBox();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.tb_PPrice = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockItems)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(1002, 70);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Stock";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Header.Controls.Add(this.button1);
            this.panel_Header.Controls.Add(this.lbl_Header);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1002, 70);
            this.panel_Header.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.53412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.12976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.29029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.60988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.39374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.694336F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Date, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(577, 4);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(88, 32);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "DATE";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Date.Enabled = false;
            this.tb_Date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(708, 5);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(201, 29);
            this.tb_Date.TabIndex = 3;
            this.tb_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(241, 5);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(200, 29);
            this.tb_ID.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(89, 4);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(112, 32);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Order ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(454, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 31);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(7, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Product & Distributor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.498595F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30816F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07754F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.229999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30816F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07754F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.499994F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Distributor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Material, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_New, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(971, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distributor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Distributor
            // 
            this.cmb_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Distributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Distributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor.FormattingEnabled = true;
            this.cmb_Distributor.Location = new System.Drawing.Point(223, 3);
            this.cmb_Distributor.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Distributor.Name = "cmb_Distributor";
            this.cmb_Distributor.Size = new System.Drawing.Size(219, 33);
            this.cmb_Distributor.TabIndex = 14;
            this.cmb_Distributor.SelectedIndexChanged += new System.EventHandler(this.cmb_Distributor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Material";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Material
            // 
            this.cmb_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material.FormattingEnabled = true;
            this.cmb_Material.Location = new System.Drawing.Point(664, 3);
            this.cmb_Material.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Material.Name = "cmb_Material";
            this.cmb_Material.Size = new System.Drawing.Size(219, 33);
            this.cmb_Material.TabIndex = 13;
            this.cmb_Material.SelectedIndexChanged += new System.EventHandler(this.cmb_Material_SelectedIndexChanged);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(898, 7);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(70, 25);
            this.btn_New.TabIndex = 13;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(7, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(983, 442);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.67967F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.32033F));
            this.tableLayoutPanel6.Controls.Add(this.dgv_Remove, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgv_StockItems, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 172);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(974, 227);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // dgv_Remove
            // 
            this.dgv_Remove.AllowUserToAddRows = false;
            this.dgv_Remove.AllowUserToDeleteRows = false;
            this.dgv_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Remove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Remove.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Remove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Remove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Remove.Location = new System.Drawing.Point(854, 3);
            this.dgv_Remove.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dgv_Remove.Name = "dgv_Remove";
            this.dgv_Remove.ReadOnly = true;
            this.dgv_Remove.RowHeadersVisible = false;
            this.dgv_Remove.RowHeadersWidth = 51;
            this.dgv_Remove.RowTemplate.Height = 24;
            this.dgv_Remove.Size = new System.Drawing.Size(117, 221);
            this.dgv_Remove.TabIndex = 5;
            this.dgv_Remove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Remove_CellClick);
            // 
            // dgv_StockItems
            // 
            this.dgv_StockItems.AllowUserToAddRows = false;
            this.dgv_StockItems.AllowUserToDeleteRows = false;
            this.dgv_StockItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_StockItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StockItems.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_StockItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_StockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockItems.Location = new System.Drawing.Point(3, 3);
            this.dgv_StockItems.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.dgv_StockItems.Name = "dgv_StockItems";
            this.dgv_StockItems.ReadOnly = true;
            this.dgv_StockItems.RowHeadersVisible = false;
            this.dgv_StockItems.RowHeadersWidth = 51;
            this.dgv_StockItems.RowTemplate.Height = 24;
            this.dgv_StockItems.Size = new System.Drawing.Size(851, 221);
            this.dgv_StockItems.TabIndex = 4;
            this.dgv_StockItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StockItems_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.984064F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.05763F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.65993F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.596767F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.05763F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.65993F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.984063F));
            this.tableLayoutPanel3.Controls.Add(this.tb_Paid, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Total, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 400);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(977, 39);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tb_Paid
            // 
            this.tb_Paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Paid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid.Location = new System.Drawing.Point(640, 5);
            this.tb_Paid.Margin = new System.Windows.Forms.Padding(15, 3, 20, 3);
            this.tb_Paid.Name = "tb_Paid";
            this.tb_Paid.Size = new System.Drawing.Size(225, 29);
            this.tb_Paid.TabIndex = 31;
            this.tb_Paid.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Paid";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Total.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(219, 5);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(15, 3, 20, 3);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(225, 29);
            this.tb_Total.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.288504F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9663782F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Colour, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmb_Colour, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Price, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Quantity, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Height, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmb_Track, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_SubCatagory, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmb_Type, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tb_AvailableStock, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmb_Size, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_PPrice, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Quantity, 3, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(971, 145);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Colour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Colour.Location = new System.Drawing.Point(606, 2);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(135, 32);
            this.lbl_Colour.TabIndex = 7;
            this.lbl_Colour.Text = "Colour";
            this.lbl_Colour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Colour
            // 
            this.cmb_Colour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Colour.FormattingEnabled = true;
            this.cmb_Colour.Location = new System.Drawing.Point(591, 39);
            this.cmb_Colour.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Colour.Name = "cmb_Colour";
            this.cmb_Colour.Size = new System.Drawing.Size(165, 33);
            this.cmb_Colour.TabIndex = 17;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(797, 111);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 31);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(583, 74);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(181, 32);
            this.lbl_Price.TabIndex = 8;
            this.lbl_Price.Text = "Purchase Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(421, 74);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(127, 32);
            this.lbl_Quantity.TabIndex = 5;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Height
            // 
            this.lbl_Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Height.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Height.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(243, 74);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(105, 32);
            this.lbl_Height.TabIndex = 3;
            this.lbl_Height.Text = "Size";
            this.lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Track
            // 
            this.cmb_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Track.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Track.FormattingEnabled = true;
            this.cmb_Track.Location = new System.Drawing.Point(24, 111);
            this.cmb_Track.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Track.Name = "cmb_Track";
            this.cmb_Track.Size = new System.Drawing.Size(165, 33);
            this.cmb_Track.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Track";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SubCatagory
            // 
            this.lbl_SubCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SubCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_SubCatagory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCatagory.Location = new System.Drawing.Point(204, 2);
            this.lbl_SubCatagory.Name = "lbl_SubCatagory";
            this.lbl_SubCatagory.Size = new System.Drawing.Size(183, 32);
            this.lbl_SubCatagory.TabIndex = 4;
            this.lbl_SubCatagory.Text = "Material Type";
            this.lbl_SubCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Type
            // 
            this.cmb_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(213, 39);
            this.cmb_Type.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(165, 33);
            this.cmb_Type.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Available Stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_AvailableStock
            // 
            this.tb_AvailableStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_AvailableStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AvailableStock.Enabled = false;
            this.tb_AvailableStock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AvailableStock.Location = new System.Drawing.Point(402, 39);
            this.tb_AvailableStock.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tb_AvailableStock.Name = "tb_AvailableStock";
            this.tb_AvailableStock.Size = new System.Drawing.Size(165, 29);
            this.tb_AvailableStock.TabIndex = 32;
            // 
            // cmb_Size
            // 
            this.cmb_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(213, 111);
            this.cmb_Size.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(165, 33);
            this.cmb_Size.TabIndex = 33;
            // 
            // tb_PPrice
            // 
            this.tb_PPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PPrice.Location = new System.Drawing.Point(591, 112);
            this.tb_PPrice.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tb_PPrice.Name = "tb_PPrice";
            this.tb_PPrice.Size = new System.Drawing.Size(165, 29);
            this.tb_PPrice.TabIndex = 28;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(402, 112);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(165, 29);
            this.tb_Quantity.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btn_Refresh, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Save, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(13, 654);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(974, 45);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(197, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(163, 33);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(610, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(163, 33);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_Header);
            this.Name = "frm_AddStock";
            this.Text = "frm_AddStock";
            this.Load += new System.EventHandler(this.frm_AddStock_Load);
            this.panel_Header.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockItems)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Material;
        private System.Windows.Forms.ComboBox cmb_Distributor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_PPrice;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_SubCatagory;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Colour;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_AvailableStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_Paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Track;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dgv_Remove;
        private System.Windows.Forms.DataGridView dgv_StockItems;
    }
}