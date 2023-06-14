namespace CFPOS
{
    partial class EmployeeManage
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
            txtId = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            dgvEmp = new DataGridView();
            btnEdit = new Button();
            btnDel = new Button();
            dtpDob = new DateTimePicker();
            txtUser = new TextBox();
            label5 = new Label();
            txtPass = new TextBox();
            label6 = new Label();
            txtDesc = new TextBox();
            label7 = new Label();
            txtSalary = new TextBox();
            label8 = new Label();
            txtRoleid = new TextBox();
            label9 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "DOB";
            // 
            // txtId
            // 
            txtId.Location = new Point(121, 22);
            txtId.Margin = new Padding(2, 1, 2, 1);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 55);
            txtName.Margin = new Padding(2, 1, 2, 1);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 184);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(504, 184);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 239);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 22);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvEmp
            // 
            dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmp.Location = new Point(141, 218);
            dgvEmp.Margin = new Padding(2, 1, 2, 1);
            dgvEmp.Name = "dgvEmp";
            dgvEmp.RowHeadersWidth = 82;
            dgvEmp.RowTemplate.Height = 41;
            dgvEmp.Size = new Size(545, 155);
            dgvEmp.TabIndex = 9;
            dgvEmp.CellDoubleClick += dgvEmp_CellDoubleClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(25, 288);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 22);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(25, 334);
            btnDel.Margin = new Padding(2, 1, 2, 1);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(81, 22);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(121, 88);
            dtpDob.Margin = new Padding(2, 1, 2, 1);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(217, 23);
            dtpDob.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(469, 19);
            txtUser.Margin = new Padding(2, 1, 2, 1);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(110, 23);
            txtUser.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 19);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(469, 52);
            txtPass.Margin = new Padding(2, 1, 2, 1);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(110, 23);
            txtPass.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 55);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(121, 124);
            txtDesc.Margin = new Padding(2, 1, 2, 1);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(217, 23);
            txtDesc.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 124);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 17;
            label7.Text = "Description";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(469, 90);
            txtSalary.Margin = new Padding(2, 1, 2, 1);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(110, 23);
            txtSalary.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 90);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 19;
            label8.Text = "Salary";
            // 
            // txtRoleid
            // 
            txtRoleid.Location = new Point(469, 121);
            txtRoleid.Margin = new Padding(2, 1, 2, 1);
            txtRoleid.Name = "txtRoleid";
            txtRoleid.Size = new Size(110, 23);
            txtRoleid.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(390, 121);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 21;
            label9.Text = "RoleID";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(622, 181);
            btnSearch.Margin = new Padding(2, 1, 2, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 22);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // EmployeeManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 410);
            Controls.Add(btnSearch);
            Controls.Add(txtRoleid);
            Controls.Add(label9);
            Controls.Add(txtSalary);
            Controls.Add(label8);
            Controls.Add(txtDesc);
            Controls.Add(label7);
            Controls.Add(txtPass);
            Controls.Add(label6);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(dtpDob);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(dgvEmp);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EmployeeManage";
            Text = "Menu";
            Load += EmployeeManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private Label label4;
        private TextBox txtSearch;
        private Button btnAdd;
        private DataGridView dgvEmp;
        private Button btnEdit;
        private Button btnDel;
        private DateTimePicker dtpDob;
        private TextBox txtUser;
        private Label label5;
        private TextBox txtPass;
        private Label label6;
        private TextBox txtDesc;
        private Label label7;
        private TextBox txtSalary;
        private Label label8;
        private TextBox txtRoleid;
        private Label label9;
        private Button btnSearch;
    }
}