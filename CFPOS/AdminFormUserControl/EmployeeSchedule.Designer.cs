namespace CFPOS
{
    partial class EmployeeSchedule
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
            lbFromDate = new Label();
            lbToDate = new Label();
            btnFilter = new Button();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtIdCRUD = new TextBox();
            txtName = new TextBox();
            txtStartCRUD = new TextBox();
            txtEndCRUD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStatusCRUD = new TextBox();
            txtDateCRUD = new TextBox();
            label7 = new Label();
            cbbScheduleId = new ComboBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(20, 27);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 62;
            dgvSchedule.RowTemplate.Height = 33;
            dgvSchedule.Size = new Size(1246, 225);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.CellDoubleClick += dgvSchedule_CellDoubleClick;
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new Point(20, 295);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new Size(54, 25);
            lbFromDate.TabIndex = 3;
            lbFromDate.Text = "From";
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new Point(20, 352);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new Size(30, 25);
            lbToDate.TabIndex = 4;
            lbToDate.Text = "To";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(83, 411);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(83, 295);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(170, 31);
            txtStart.TabIndex = 6;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(83, 352);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(170, 31);
            txtEnd.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(518, 555);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(698, 555);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(896, 555);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtIdCRUD
            // 
            txtIdCRUD.Enabled = false;
            txtIdCRUD.Location = new Point(480, 304);
            txtIdCRUD.Name = "txtIdCRUD";
            txtIdCRUD.Size = new Size(150, 31);
            txtIdCRUD.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(480, 389);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 13;
            // 
            // txtStartCRUD
            // 
            txtStartCRUD.Enabled = false;
            txtStartCRUD.Location = new Point(786, 301);
            txtStartCRUD.Name = "txtStartCRUD";
            txtStartCRUD.Size = new Size(150, 31);
            txtStartCRUD.TabIndex = 14;
            // 
            // txtEndCRUD
            // 
            txtEndCRUD.Enabled = false;
            txtEndCRUD.Location = new Point(786, 389);
            txtEndCRUD.Name = "txtEndCRUD";
            txtEndCRUD.Size = new Size(150, 31);
            txtEndCRUD.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 306);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 18;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 395);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 304);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 20;
            label3.Text = "Start";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(716, 482);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 21;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(723, 395);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 22;
            label5.Text = "End";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1031, 301);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 23;
            label6.Text = "Status";
            // 
            // txtStatusCRUD
            // 
            txtStatusCRUD.Enabled = false;
            txtStatusCRUD.Location = new Point(1116, 300);
            txtStatusCRUD.Name = "txtStatusCRUD";
            txtStatusCRUD.Size = new Size(150, 31);
            txtStatusCRUD.TabIndex = 26;
            // 
            // txtDateCRUD
            // 
            txtDateCRUD.Enabled = false;
            txtDateCRUD.Location = new Point(786, 476);
            txtDateCRUD.Name = "txtDateCRUD";
            txtDateCRUD.Size = new Size(150, 31);
            txtDateCRUD.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 490);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 28;
            label7.Text = "Schedule ID";
            // 
            // cbbScheduleId
            // 
            cbbScheduleId.Enabled = false;
            cbbScheduleId.FormattingEnabled = true;
            cbbScheduleId.Location = new Point(480, 482);
            cbbScheduleId.Name = "cbbScheduleId";
            cbbScheduleId.Size = new Size(150, 33);
            cbbScheduleId.TabIndex = 29;
            cbbScheduleId.SelectedIndexChanged += cbbScheduleId_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(83, 451);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 30;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // EmployeeSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(cbbScheduleId);
            Controls.Add(label7);
            Controls.Add(txtDateCRUD);
            Controls.Add(txtStatusCRUD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndCRUD);
            Controls.Add(txtStartCRUD);
            Controls.Add(txtName);
            Controls.Add(txtIdCRUD);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(btnFilter);
            Controls.Add(lbToDate);
            Controls.Add(lbFromDate);
            Controls.Add(dgvSchedule);
            Name = "EmployeeSchedule";
            Size = new Size(1350, 638);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private Label lbFromDate;
        private Label lbToDate;
        private Button btnFilter;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtIdCRUD;
        private TextBox txtName;
        private TextBox txtStartCRUD;
        private TextBox txtEndCRUD;
        private DateTimePicker dtpDateCRUD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStatusCRUD;
        private TextBox txtDateCRUD;
        private Label label7;
        private ComboBox cbbScheduleId;
        private Button btnReset;
    }
}
