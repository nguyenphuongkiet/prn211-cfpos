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
            label2 = new Label();
            cboItem = new ComboBox();
            nudQuantity = new NumericUpDown();
            label1 = new Label();
            cboCategory = new ComboBox();
            label3 = new Label();
            txtNote = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            txtTotal = new TextBox();
            dgvOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            btnLogout = new Button();
            btnExport = new Button();
            btnInfo = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboItem);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(315, 24);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 158);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "DRINK'S NAME";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(129, 43);
            cboItem.Margin = new Padding(2, 1, 2, 1);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(132, 23);
            cboItem.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(130, 122);
            nudQuantity.Margin = new Padding(2, 1, 2, 1);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(130, 23);
            nudQuantity.TabIndex = 6;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "CATEGORY";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(129, 9);
            cboCategory.Margin = new Padding(2, 1, 2, 1);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(132, 23);
            cboCategory.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "QUANTITY";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(130, 80);
            txtNote.Margin = new Padding(2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(327, 23);
            txtNote.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(347, 43);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 83);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 3;
            label6.Text = "NOTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 45);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 2;
            label5.Text = "PRICE";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(dgvOrder);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(315, 208);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 237);
            panel2.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(94, 199);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(182, 23);
            txtTotal.TabIndex = 9;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvOrder.Location = new Point(15, 10);
            dgvOrder.Margin = new Padding(2, 1, 2, 1);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 82;
            dgvOrder.RowTemplate.Height = 41;
            dgvOrder.Size = new Size(500, 164);
            dgvOrder.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Note";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 196);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 8;
            label7.Text = "Total";
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(6, 24);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 158);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 110);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 104);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 9;
            label8.Text = "TIME";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(82, 100);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 28);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 30);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 8;
            label4.Text = "Employee Name";
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
            btnLogout.Location = new Point(153, 170);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(102, 54);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "SIGN OUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(15, 170);
            btnExport.Margin = new Padding(2, 1, 2, 1);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(102, 54);
            btnExport.TabIndex = 10;
            btnExport.Text = "EXPORT";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(153, 92);
            btnInfo.Margin = new Padding(2, 1, 2, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(102, 54);
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
            btnEdit.Size = new Size(102, 54);
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
            btnAdd.Click += btnAdd_Click;
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
            ClientSize = new Size(830, 456);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
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
        private TextBox txtNote;
        private TextBox txtPrice;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtTotal;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}