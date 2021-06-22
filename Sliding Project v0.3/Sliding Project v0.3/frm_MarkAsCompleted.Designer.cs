namespace Sliding_Project_v0._3
{
    partial class frm_ManageOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CancelOrder = new System.Windows.Forms.Button();
            this.btn_UpdateOrder = new System.Windows.Forms.Button();
            this.btn_AcceptMoney = new System.Windows.Forms.Button();
            this.btn_MarkAsCompleted = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ManageOrders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 70);
            this.panel1.TabIndex = 0;
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
            this.lbl_Header.Text = "Manage Orders";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 75);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.792268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.48067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.48067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.84013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.237184F));
            this.tableLayoutPanel1.Controls.Add(this.tb_ID, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Add, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(559, 8);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(192, 29);
            this.tb_ID.TabIndex = 14;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(431, 3);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(102, 38);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "NAME";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(210, 8);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(192, 29);
            this.tb_Name.TabIndex = 16;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(83, 6);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(96, 32);
            this.lbl_ID.TabIndex = 13;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(783, 7);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 31);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Search";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_ManageOrders);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 542);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salary : High To Low",
            "Salary : Low To High"});
            this.comboBox1.Location = new System.Drawing.Point(352, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 33);
            this.comboBox1.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tableLayoutPanel2.Controls.Add(this.btn_CancelOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_UpdateOrder, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_AcceptMoney, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_MarkAsCompleted, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 488);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(968, 45);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // btn_CancelOrder
            // 
            this.btn_CancelOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CancelOrder.FlatAppearance.BorderSize = 0;
            this.btn_CancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelOrder.Location = new System.Drawing.Point(55, 7);
            this.btn_CancelOrder.Name = "btn_CancelOrder";
            this.btn_CancelOrder.Size = new System.Drawing.Size(197, 31);
            this.btn_CancelOrder.TabIndex = 21;
            this.btn_CancelOrder.Text = "Cancel Order";
            this.btn_CancelOrder.UseVisualStyleBackColor = false;
            this.btn_CancelOrder.Click += new System.EventHandler(this.btn_CancelOrder_Click);
            // 
            // btn_UpdateOrder
            // 
            this.btn_UpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UpdateOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UpdateOrder.FlatAppearance.BorderSize = 0;
            this.btn_UpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateOrder.Location = new System.Drawing.Point(274, 7);
            this.btn_UpdateOrder.Name = "btn_UpdateOrder";
            this.btn_UpdateOrder.Size = new System.Drawing.Size(197, 31);
            this.btn_UpdateOrder.TabIndex = 22;
            this.btn_UpdateOrder.Text = "Update Order";
            this.btn_UpdateOrder.UseVisualStyleBackColor = false;
            this.btn_UpdateOrder.Click += new System.EventHandler(this.btn_UpdateOreder_Click);
            // 
            // btn_AcceptMoney
            // 
            this.btn_AcceptMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AcceptMoney.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AcceptMoney.FlatAppearance.BorderSize = 0;
            this.btn_AcceptMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AcceptMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcceptMoney.Location = new System.Drawing.Point(493, 7);
            this.btn_AcceptMoney.Name = "btn_AcceptMoney";
            this.btn_AcceptMoney.Size = new System.Drawing.Size(197, 31);
            this.btn_AcceptMoney.TabIndex = 23;
            this.btn_AcceptMoney.Text = "Accept Money";
            this.btn_AcceptMoney.UseVisualStyleBackColor = false;
            this.btn_AcceptMoney.Click += new System.EventHandler(this.btn_AcceptMoney_Click);
            // 
            // btn_MarkAsCompleted
            // 
            this.btn_MarkAsCompleted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MarkAsCompleted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MarkAsCompleted.FlatAppearance.BorderSize = 0;
            this.btn_MarkAsCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarkAsCompleted.Location = new System.Drawing.Point(712, 7);
            this.btn_MarkAsCompleted.Name = "btn_MarkAsCompleted";
            this.btn_MarkAsCompleted.Size = new System.Drawing.Size(197, 31);
            this.btn_MarkAsCompleted.TabIndex = 24;
            this.btn_MarkAsCompleted.Text = "Mark As Completed";
            this.btn_MarkAsCompleted.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(644, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 27);
            this.button2.TabIndex = 32;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sort By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ManageOrders
            // 
            this.dgv_ManageOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ManageOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageOrders.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_ManageOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ManageOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageOrders.Location = new System.Drawing.Point(7, 62);
            this.dgv_ManageOrders.Name = "dgv_ManageOrders";
            this.dgv_ManageOrders.RowHeadersVisible = false;
            this.dgv_ManageOrders.RowHeadersWidth = 51;
            this.dgv_ManageOrders.RowTemplate.Height = 24;
            this.dgv_ManageOrders.Size = new System.Drawing.Size(968, 419);
            this.dgv_ManageOrders.TabIndex = 36;
            this.dgv_ManageOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ManageOrders_CellClick);
            // 
            // frm_ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ManageOrders";
            this.Text = "Action Center";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_CancelOrder;
        private System.Windows.Forms.Button btn_UpdateOrder;
        private System.Windows.Forms.Button btn_AcceptMoney;
        private System.Windows.Forms.Button btn_MarkAsCompleted;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ManageOrders;
    }
}