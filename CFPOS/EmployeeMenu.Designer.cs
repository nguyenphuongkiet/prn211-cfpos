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
            label7 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
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
            textBox4 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboItem);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(585, 51);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 337);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 268);
            label7.Name = "label7";
            label7.Size = new Size(65, 32);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(603, 39);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(645, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 175);
            label6.Name = "label6";
            label6.Size = new Size(159, 32);
            label6.TabIndex = 3;
            label6.Text = "DESCRIPTION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 90);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 2;
            label5.Text = "PRICE";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvOrder);
            panel2.Location = new Point(585, 444);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 506);
            panel2.TabIndex = 1;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(28, 21);
            dgvOrder.Margin = new Padding(4, 2, 4, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 82;
            dgvOrder.RowTemplate.Height = 41;
            dgvOrder.Size = new Size(930, 467);
            dgvOrder.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(11, 51);
            panel3.Margin = new Padding(4, 2, 4, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 337);
            panel3.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(175, 261);
            nudQuantity.Margin = new Padding(4, 2, 4, 2);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(240, 39);
            nudQuantity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 263);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 4;
            label2.Text = "DRINK'S NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 3;
            label1.Text = "Category";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(239, 91);
            cboItem.Margin = new Padding(4, 2, 4, 2);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(242, 40);
            cboItem.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(239, 20);
            cboCategory.Margin = new Padding(4, 2, 4, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 40);
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
            panel4.Location = new Point(11, 444);
            panel4.Margin = new Padding(4, 2, 4, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(501, 506);
            panel4.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(284, 361);
            btnLogout.Margin = new Padding(4, 2, 4, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(188, 115);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "SIGN OUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(28, 361);
            btnExport.Margin = new Padding(4, 2, 4, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(188, 115);
            btnExport.TabIndex = 10;
            btnExport.Text = "EXPORT";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(284, 196);
            btnInfo.Margin = new Padding(4, 2, 4, 2);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(188, 115);
            btnInfo.TabIndex = 9;
            btnInfo.Text = "INFO EMP";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(28, 196);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 115);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(284, 32);
            btnEdit.Margin = new Padding(4, 2, 4, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 115);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 32);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 115);
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
            // textBox4
            // 
            textBox4.Location = new Point(690, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 39);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 64);
            label4.Name = "label4";
            label4.Size = new Size(190, 32);
            label4.TabIndex = 8;
            label4.Text = "Employee Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(153, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(301, 39);
            textBox5.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 221);
            label8.Name = "label8";
            label8.Size = new Size(67, 32);
            label8.TabIndex = 9;
            label8.Text = "TIME";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 233);
            label9.Name = "label9";
            label9.Size = new Size(0, 32);
            label9.TabIndex = 10;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 973);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox textBox4;
        private Label label9;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label4;
    }
}