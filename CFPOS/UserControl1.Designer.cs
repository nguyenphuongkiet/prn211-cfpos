namespace CFPOS
{
    partial class UserControl1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtSalary = new TextBox();
            txtRoleid = new TextBox();
            dtpDob = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 125);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 208);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 2;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 292);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 384);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 4;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 475);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 561);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 6;
            label7.Text = "Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 653);
            label8.Name = "label8";
            label8.Size = new Size(83, 32);
            label8.TabIndex = 7;
            label8.Text = "RoleID";
            // 
            // txtId
            // 
            txtId.Location = new Point(343, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(400, 39);
            txtId.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(343, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 39);
            txtName.TabIndex = 9;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(343, 292);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(400, 39);
            txtDesc.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(343, 381);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(400, 39);
            txtUser.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(343, 472);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(400, 39);
            txtPass.TabIndex = 13;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(343, 558);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(400, 39);
            txtSalary.TabIndex = 14;
            // 
            // txtRoleid
            // 
            txtRoleid.Location = new Point(343, 650);
            txtRoleid.Name = "txtRoleid";
            txtRoleid.Size = new Size(400, 39);
            txtRoleid.TabIndex = 15;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(343, 208);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(400, 39);
            dtpDob.TabIndex = 16;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpDob);
            Controls.Add(txtRoleid);
            Controls.Add(txtSalary);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(1483, 993);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtSalary;
        private TextBox txtRoleid;
        private DateTimePicker dtpDob;
    }
}
