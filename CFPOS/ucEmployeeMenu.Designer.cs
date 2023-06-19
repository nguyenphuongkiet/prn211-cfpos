namespace CFPOS
{
    partial class ucEmployeeMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            dgvOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnPay = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 14;
            label2.Text = "DRINK'S NAME";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(190, 68);
            cboItem.Margin = new Padding(2, 1, 2, 1);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(150, 28);
            cboItem.TabIndex = 10;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(440, 70);
            nudQuantity.Margin = new Padding(2, 1, 2, 1);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(149, 27);
            nudQuantity.TabIndex = 18;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 176);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 31);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 12;
            label1.Text = "CATEGORY";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(73, 176);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 31);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(190, 23);
            cboCategory.Margin = new Padding(2, 1, 2, 1);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(150, 28);
            cboCategory.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(491, 175);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 32);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 16;
            label3.Text = "QUANTITY";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(192, 118);
            txtNote.Margin = new Padding(2, 3, 2, 3);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(396, 27);
            txtNote.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(440, 24);
            txtPrice.Margin = new Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 27);
            txtPrice.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "NOTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 27);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 11;
            label5.Text = "PRICE";
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvOrder.Location = new Point(38, 232);
            dgvOrder.Margin = new Padding(2, 1, 2, 1);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 82;
            dgvOrder.RowTemplate.Height = 41;
            dgvOrder.Size = new Size(571, 219);
            dgvOrder.TabIndex = 22;
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
            // btnPay
            // 
            btnPay.Location = new Point(450, 478);
            btnPay.Margin = new Padding(2, 1, 2, 1);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(136, 57);
            btnPay.TabIndex = 25;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(123, 491);
            txtTotal.Margin = new Padding(2, 3, 2, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(207, 27);
            txtTotal.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 487);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 31);
            label7.TabIndex = 23;
            label7.Text = "Total";
            // 
            // ucEmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPay);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(dgvOrder);
            Controls.Add(label2);
            Controls.Add(cboItem);
            Controls.Add(nudQuantity);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(cboCategory);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtNote);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "ucEmployeeMenu";
            Size = new Size(642, 561);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cboItem;
        private NumericUpDown nudQuantity;
        private Button btnDelete;
        private Label label1;
        private Button btnEdit;
        private ComboBox cboCategory;
        private Button btnAdd;
        private Label label3;
        private TextBox txtNote;
        private TextBox txtPrice;
        private Label label6;
        private Label label5;
        private DataGridView dgvOrder;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnPay;
        private TextBox txtTotal;
        private Label label7;
    }
}
