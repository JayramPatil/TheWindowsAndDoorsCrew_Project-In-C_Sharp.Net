namespace Sliding_Project_v0._3
{
    partial class frm_ManageEmployees
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_RemoveEmployee = new System.Windows.Forms.Button();
            this.btn_UpdateEmployee = new System.Windows.Forms.Button();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.btn_EditSalary = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_ManageEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dgv_ManageEmployee);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 542);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
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
            this.tableLayoutPanel2.Controls.Add(this.btn_RemoveEmployee, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_UpdateEmployee, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_AddEmployee, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_EditSalary, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 485);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(968, 45);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // btn_RemoveEmployee
            // 
            this.btn_RemoveEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoveEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_RemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btn_RemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveEmployee.Location = new System.Drawing.Point(55, 7);
            this.btn_RemoveEmployee.Name = "btn_RemoveEmployee";
            this.btn_RemoveEmployee.Size = new System.Drawing.Size(197, 31);
            this.btn_RemoveEmployee.TabIndex = 21;
            this.btn_RemoveEmployee.Text = "Remove Employee";
            this.btn_RemoveEmployee.UseVisualStyleBackColor = false;
            this.btn_RemoveEmployee.Click += new System.EventHandler(this.btn_RemoveEmployee_Click);
            // 
            // btn_UpdateEmployee
            // 
            this.btn_UpdateEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btn_UpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateEmployee.Location = new System.Drawing.Point(274, 7);
            this.btn_UpdateEmployee.Name = "btn_UpdateEmployee";
            this.btn_UpdateEmployee.Size = new System.Drawing.Size(197, 31);
            this.btn_UpdateEmployee.TabIndex = 22;
            this.btn_UpdateEmployee.Text = "Update Details ";
            this.btn_UpdateEmployee.UseVisualStyleBackColor = false;
            this.btn_UpdateEmployee.Click += new System.EventHandler(this.btn_UpdateEmployee_Click);
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddEmployee.FlatAppearance.BorderSize = 0;
            this.btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEmployee.Location = new System.Drawing.Point(493, 7);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(197, 31);
            this.btn_AddEmployee.TabIndex = 23;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = false;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // btn_EditSalary
            // 
            this.btn_EditSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EditSalary.FlatAppearance.BorderSize = 0;
            this.btn_EditSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditSalary.Location = new System.Drawing.Point(712, 7);
            this.btn_EditSalary.Name = "btn_EditSalary";
            this.btn_EditSalary.Size = new System.Drawing.Size(197, 31);
            this.btn_EditSalary.TabIndex = 24;
            this.btn_EditSalary.Text = "Edit Salary";
            this.btn_EditSalary.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(352, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 33);
            this.comboBox1.TabIndex = 35;
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
            // dgv_ManageEmployee
            // 
            this.dgv_ManageEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ManageEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageEmployee.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_ManageEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ManageEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageEmployee.Location = new System.Drawing.Point(5, 60);
            this.dgv_ManageEmployee.Name = "dgv_ManageEmployee";
            this.dgv_ManageEmployee.RowHeadersVisible = false;
            this.dgv_ManageEmployee.RowHeadersWidth = 51;
            this.dgv_ManageEmployee.RowTemplate.Height = 24;
            this.dgv_ManageEmployee.Size = new System.Drawing.Size(968, 419);
            this.dgv_ManageEmployee.TabIndex = 33;
            this.dgv_ManageEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ManageEmployee_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "POST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbl_Header.Text = "Manage Employees";
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
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 75);
            this.groupBox1.TabIndex = 27;
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
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 5, 0);
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
            this.lbl_Name.Location = new System.Drawing.Point(416, 3);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(132, 38);
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
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(783, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(131, 31);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // frm_ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ManageEmployees";
            this.Text = "Manage Employees";
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_ManageEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_RemoveEmployee;
        private System.Windows.Forms.Button btn_UpdateEmployee;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Button btn_EditSalary;
    }
}