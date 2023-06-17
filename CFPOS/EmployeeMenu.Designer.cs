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
            panelContainer = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            txtTime = new TextBox();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            btnOrder = new Button();
            btnLogout = new Button();
            btnInfo = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            timer1 = new System.Windows.Forms.Timer(components);
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(360, 32);
            panelContainer.Margin = new Padding(2, 1, 2, 1);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(642, 561);
            panelContainer.TabIndex = 0;
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
            panel3.Size = new Size(331, 211);
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
            txtTime.Enabled = false;
            txtTime.Location = new Point(135, 135);
            txtTime.Margin = new Padding(2, 3, 2, 3);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(171, 27);
            txtTime.TabIndex = 8;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Enabled = false;
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
            panel4.Controls.Add(btnOrder);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnInfo);
            panel4.Location = new Point(7, 277);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 316);
            panel4.TabIndex = 2;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(7, 41);
            btnOrder.Margin = new Padding(2, 1, 2, 1);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(299, 72);
            btnOrder.TabIndex = 12;
            btnOrder.Text = "PLACE ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(6, 235);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(299, 72);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "SIGN OUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(6, 138);
            btnInfo.Margin = new Padding(2, 1, 2, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(299, 72);
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
            ClientSize = new Size(1018, 608);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelContainer);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel panel3;
        private Panel panel4;
        private Button btnLogout;
        private Button btnExport;
        private Button btnInfo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label9;
        private Label label8;
        private TextBox txtTime;
        private TextBox txtEmployeeName;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnOrder;
    }
}