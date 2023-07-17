namespace CFPOS
{
    partial class AdminSchedule
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
            dgvSchedule = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtTimeStart = new TextBox();
            txtTimeEnd = new TextBox();
            cbbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbbDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(47, 31);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 62;
            dgvSchedule.RowTemplate.Height = 33;
            dgvSchedule.Size = new Size(1229, 281);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.CellDoubleClick += dgvSchedule_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(47, 330);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(47, 392);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTimeStart
            // 
            txtTimeStart.Location = new Point(711, 330);
            txtTimeStart.Name = "txtTimeStart";
            txtTimeStart.Size = new Size(235, 31);
            txtTimeStart.TabIndex = 3;
            // 
            // txtTimeEnd
            // 
            txtTimeEnd.Location = new Point(711, 383);
            txtTimeEnd.Name = "txtTimeEnd";
            txtTimeEnd.Size = new Size(235, 31);
            txtTimeEnd.TabIndex = 4;
            // 
            // cbbStatus
            // 
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(711, 489);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(235, 33);
            cbbStatus.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1032, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 54);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1032, 392);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 54);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(589, 336);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 10;
            label1.Text = "Time Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 386);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 11;
            label2.Text = "Time End";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 442);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 12;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 497);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 13;
            label4.Text = "Status";
            // 
            // cbbDate
            // 
            cbbDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDate.FormattingEnabled = true;
            cbbDate.Location = new Point(712, 437);
            cbbDate.Name = "cbbDate";
            cbbDate.Size = new Size(234, 33);
            cbbDate.TabIndex = 14;
            // 
            // AdminSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbbStatus);
            Controls.Add(txtTimeEnd);
            Controls.Add(txtTimeStart);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvSchedule);
            Name = "AdminSchedule";
            Size = new Size(1322, 555);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtTimeStart;
        private TextBox txtTimeEnd;
        private ComboBox cbbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbbDate;
    }
}
