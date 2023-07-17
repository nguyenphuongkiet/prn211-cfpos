namespace CFPOS
{
    partial class AdminDrinks
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvAdminDrinks = new DataGridView();
            txtItemName = new TextBox();
            txtItemPrice = new TextBox();
            txtItemDescription = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ID = new Label();
            txtItemId = new TextBox();
            ItemStatus = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAdminDrinks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 338);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 399);
            label2.Name = "label2";
            label2.Size = new Size(111, 26);
            label2.TabIndex = 2;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 455);
            label3.Name = "label3";
            label3.Size = new Size(55, 26);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(110, 559);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // dgvAdminDrinks
            // 
            dgvAdminDrinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminDrinks.Location = new Point(82, 15);
            dgvAdminDrinks.Name = "dgvAdminDrinks";
            dgvAdminDrinks.RowTemplate.Height = 25;
            dgvAdminDrinks.Size = new Size(764, 236);
            dgvAdminDrinks.TabIndex = 5;
            dgvAdminDrinks.CellDoubleClick += dgvAdminDrinks_CellDoubleClick;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(268, 404);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(368, 23);
            txtItemName.TabIndex = 6;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(268, 460);
            txtItemPrice.MaxLength = 10;
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(155, 23);
            txtItemPrice.TabIndex = 7;
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(268, 564);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(368, 23);
            txtItemDescription.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(268, 343);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(255, 255, 255);
            btnAdd.Location = new Point(698, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 40);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 150, 243);
            btnUpdate.FlatAppearance.BorderColor = Color.Black;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(255, 255, 255);
            btnUpdate.Location = new Point(698, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 40);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(255, 255, 255);
            btnDelete.Location = new Point(698, 513);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 40);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(110, 278);
            ID.Name = "ID";
            ID.Size = new Size(36, 26);
            ID.TabIndex = 15;
            ID.Text = "ID";
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(268, 283);
            txtItemId.Name = "txtItemId";
            txtItemId.ReadOnly = true;
            txtItemId.Size = new Size(53, 23);
            txtItemId.TabIndex = 16;
            // 
            // ItemStatus
            // 
            ItemStatus.AutoSize = true;
            ItemStatus.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ItemStatus.Location = new Point(110, 508);
            ItemStatus.Name = "ItemStatus";
            ItemStatus.Size = new Size(70, 26);
            ItemStatus.TabIndex = 17;
            ItemStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(268, 513);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 18;
            // 
            // AdminDrinks
            // 
            BackColor = Color.White;
            Controls.Add(cmbStatus);
            Controls.Add(ItemStatus);
            Controls.Add(txtItemId);
            Controls.Add(ID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtItemDescription);
            Controls.Add(txtItemPrice);
            Controls.Add(txtItemName);
            Controls.Add(dgvAdminDrinks);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminDrinks";
            Size = new Size(952, 629);
            ((System.ComponentModel.ISupportInitialize)dgvAdminDrinks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtItemName;
        private TextBox txtItemPrice;
        private TextBox txtItemDescription;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvAdminDrinks;
        private Label ID;
        private TextBox txtItemId;
        private Label ItemStatus;
        private ComboBox cmbStatus;
    }

    #endregion
}
