namespace CFPOS
{
    partial class EmployeeMenu
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
            panel1 = new Panel();
            btnTable6 = new Button();
            btnTable5 = new Button();
            btnTable4 = new Button();
            btnTable3 = new Button();
            btnTable2 = new Button();
            btnTable1 = new Button();
            panel2 = new Panel();
            dgvOrder = new DataGridView();
            panel3 = new Panel();
            nudQuantity = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboItem = new ComboBox();
            cboCategory = new ComboBox();
            panel4 = new Panel();
            btnLogout = new Button();
            btnExport = new Button();
            btnInfo = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTable6);
            panel1.Controls.Add(btnTable5);
            panel1.Controls.Add(btnTable4);
            panel1.Controls.Add(btnTable3);
            panel1.Controls.Add(btnTable2);
            panel1.Controls.Add(btnTable1);
            panel1.Location = new Point(315, 24);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 158);
            panel1.TabIndex = 0;
            // 
            // btnTable6
            // 
            btnTable6.BackColor = Color.White;
            btnTable6.Location = new Point(391, 82);
            btnTable6.Margin = new Padding(2, 1, 2, 1);
            btnTable6.Name = "btnTable6";
            btnTable6.Size = new Size(116, 64);
            btnTable6.TabIndex = 5;
            btnTable6.Text = "Table 6";
            btnTable6.UseVisualStyleBackColor = false;
            // 
            // btnTable5
            // 
            btnTable5.BackColor = Color.White;
            btnTable5.Location = new Point(207, 82);
            btnTable5.Margin = new Padding(2, 1, 2, 1);
            btnTable5.Name = "btnTable5";
            btnTable5.Size = new Size(116, 64);
            btnTable5.TabIndex = 4;
            btnTable5.Text = "Table 5";
            btnTable5.UseVisualStyleBackColor = false;
            // 
            // btnTable4
            // 
            btnTable4.BackColor = Color.White;
            btnTable4.Location = new Point(24, 82);
            btnTable4.Margin = new Padding(2, 1, 2, 1);
            btnTable4.Name = "btnTable4";
            btnTable4.Size = new Size(116, 64);
            btnTable4.TabIndex = 3;
            btnTable4.Text = "Table 4";
            btnTable4.UseVisualStyleBackColor = false;
            // 
            // btnTable3
            // 
            btnTable3.BackColor = Color.White;
            btnTable3.Location = new Point(391, 11);
            btnTable3.Margin = new Padding(2, 1, 2, 1);
            btnTable3.Name = "btnTable3";
            btnTable3.Size = new Size(116, 64);
            btnTable3.TabIndex = 2;
            btnTable3.Text = "Table 3";
            btnTable3.UseVisualStyleBackColor = false;
            // 
            // btnTable2
            // 
            btnTable2.BackColor = Color.White;
            btnTable2.Location = new Point(207, 11);
            btnTable2.Margin = new Padding(2, 1, 2, 1);
            btnTable2.Name = "btnTable2";
            btnTable2.Size = new Size(116, 64);
            btnTable2.TabIndex = 1;
            btnTable2.Text = "Table 2";
            btnTable2.UseVisualStyleBackColor = false;
            // 
            // btnTable1
            // 
            btnTable1.BackColor = Color.White;
            btnTable1.Location = new Point(24, 11);
            btnTable1.Margin = new Padding(2, 1, 2, 1);
            btnTable1.Name = "btnTable1";
            btnTable1.Size = new Size(116, 64);
            btnTable1.TabIndex = 0;
            btnTable1.Text = "Table 1";
            btnTable1.UseVisualStyleBackColor = false;
            btnTable1.Click += btnTable1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvOrder);
            panel2.Location = new Point(315, 208);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 237);
            panel2.TabIndex = 1;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(15, 10);
            dgvOrder.Margin = new Padding(2, 1, 2, 1);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 82;
            dgvOrder.RowTemplate.Height = 41;
            dgvOrder.Size = new Size(501, 219);
            dgvOrder.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(nudQuantity);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cboItem);
            panel3.Controls.Add(cboCategory);
            panel3.Location = new Point(6, 24);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 158);
            panel3.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(119, 106);
            nudQuantity.Margin = new Padding(2, 1, 2, 1);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(129, 23);
            nudQuantity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "DRINK'S NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Category";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(118, 65);
            cboItem.Margin = new Padding(2, 1, 2, 1);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(132, 23);
            cboItem.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(118, 26);
            cboCategory.Margin = new Padding(2, 1, 2, 1);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(132, 23);
            cboCategory.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnInfo);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(btnAdd);
            panel4.Location = new Point(6, 208);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 237);
            panel4.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(153, 169);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 54);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "SIGN OUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(15, 169);
            btnExport.Margin = new Padding(2, 1, 2, 1);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(101, 54);
            btnExport.TabIndex = 10;
            btnExport.Text = "EXPORT";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(153, 92);
            btnInfo.Margin = new Padding(2, 1, 2, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(101, 54);
            btnInfo.TabIndex = 9;
            btnInfo.Text = "INFO EMP";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 92);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 54);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(153, 15);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 54);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 15);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 54);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 456);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnTable6;
        private Button btnTable5;
        private Button btnTable4;
        private Button btnTable3;
        private Button btnTable2;
        private Button btnTable1;
        private DataGridView dgvOrder;
        private Button btnLogout;
        private Button btnExport;
        private Button btnInfo;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private NumericUpDown nudQuantity;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboItem;
        private ComboBox cboCategory;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}