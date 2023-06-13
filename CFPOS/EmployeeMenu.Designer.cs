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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
            panel1 = new Panel();
            label2 = new Label();
            cboItem = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnDelete = new Button();
            label1 = new Label();
            btnEdit = new Button();
            cboCategory = new ComboBox();
            btnAdd = new Button();
            label3 = new Label();
            txtNote = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btnPay = new Button();
            txtTotal = new TextBox();
            dgvOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            txtTime = new TextBox();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            btnLogout = new Button();
            btnInfo = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            timer1 = new System.Windows.Forms.Timer(components);
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(360, 32);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 211);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "DRINK'S NAME";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(147, 57);
            cboItem.Margin = new Padding(2, 1, 2, 1);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(150, 28);
            cboItem.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(397, 59);
            nudQuantity.Margin = new Padding(2, 1, 2, 1);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(149, 27);
            nudQuantity.TabIndex = 6;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(147, 165);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "CATEGORY";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(30, 165);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 31);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(147, 12);
            cboCategory.Margin = new Padding(2, 1, 2, 1);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(150, 28);
            cboCategory.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(448, 164);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 32);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "QUANTITY";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(149, 107);
            txtNote.Margin = new Padding(2, 3, 2, 3);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(396, 27);
            txtNote.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(397, 13);
            txtPrice.Margin = new Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 27);
            txtPrice.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 111);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 3;
            label6.Text = "NOTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 16);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 2;
            label5.Text = "PRICE";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(dgvOrder);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(360, 277);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 316);
            panel2.TabIndex = 1;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(427, 250);
            btnPay.Margin = new Padding(2, 1, 2, 1);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(136, 57);
            btnPay.TabIndex = 12;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(107, 265);
            txtTotal.Margin = new Padding(2, 3, 2, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(207, 27);
            txtTotal.TabIndex = 9;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvOrder.Location = new Point(17, 13);
            dgvOrder.Margin = new Padding(2, 1, 2, 1);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 82;
            dgvOrder.RowTemplate.Height = 41;
            dgvOrder.Size = new Size(571, 219);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
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
            // Column6
            // 
            Column6.HeaderText = "Category";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 261);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 31);
            label7.TabIndex = 8;
            label7.Text = "Total";
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtTime);
            panel3.Controls.Add(txtEmployeeName);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(7, 32);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 211);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 147);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 139);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 9;
            label8.Text = "TIME";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(135, 135);
            txtTime.Margin = new Padding(2, 3, 2, 3);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(171, 27);
            txtTime.TabIndex = 8;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(135, 36);
            txtEmployeeName.Margin = new Padding(2, 3, 2, 3);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(171, 27);
            txtEmployeeName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 40);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 8;
            label4.Text = "EMPLOYEE NAME";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnInfo);
            panel4.Location = new Point(7, 277);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 316);
            panel4.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(175, 227);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 72);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "SIGN OUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(22, 227);
            btnInfo.Margin = new Padding(2, 1, 2, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(117, 72);
            btnInfo.TabIndex = 9;
            btnInfo.Text = "INFO EMP";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 608);
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
        private TextBox txtTime;
        private TextBox txtEmployeeName;
        private Label label4;
        private TextBox txtTotal;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Timer timer1;
        private Button btnPay;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn Column6;
    }
}