namespace CFPOS
{
    partial class AdminMenu
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
            panelTab = new Panel();
            button6 = new Button();
            button5 = new Button();
            btnSchedule = new Button();
            button3 = new Button();
            btnAdminDrinks = new Button();
            btnEmp = new Button();
            panelContainer = new Panel();
            panelTab.SuspendLayout();
            SuspendLayout();
            // 
            // panelTab
            // 
            panelTab.Controls.Add(button6);
            panelTab.Controls.Add(button5);
            panelTab.Controls.Add(btnSchedule);
            panelTab.Controls.Add(button3);
            panelTab.Controls.Add(btnAdminDrinks);
            panelTab.Controls.Add(btnEmp);
            panelTab.Location = new Point(11, 13);
            panelTab.Margin = new Padding(4, 2, 4, 2);
            panelTab.Name = "panelTab";
            panelTab.Size = new Size(245, 932);
            panelTab.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(28, 791);
            button6.Margin = new Padding(4, 2, 4, 2);
            button6.Name = "button6";
            button6.Size = new Size(188, 117);
            button6.TabIndex = 5;
            button6.Text = "ĐĂNG XUẤT";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(28, 646);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(188, 117);
            button5.TabIndex = 4;
            button5.Text = "IN PROGRESS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(28, 499);
            btnSchedule.Margin = new Padding(4, 2, 4, 2);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(188, 117);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "CA TRỰC";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 350);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(188, 117);
            button3.TabIndex = 2;
            button3.Text = "DOANH THU";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAdminDrinks
            // 
            btnAdminDrinks.Location = new Point(28, 190);
            btnAdminDrinks.Margin = new Padding(4, 2, 4, 2);
            btnAdminDrinks.Name = "btnAdminDrinks";
            btnAdminDrinks.Size = new Size(188, 117);
            btnAdminDrinks.TabIndex = 1;
            btnAdminDrinks.Text = "ĐỒ UỐNG";
            btnAdminDrinks.UseVisualStyleBackColor = true;
            btnAdminDrinks.Click += btnAdminDrinks_Click;
            // 
            // btnEmp
            // 
            btnEmp.Location = new Point(28, 30);
            btnEmp.Margin = new Padding(4, 2, 4, 2);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(188, 117);
            btnEmp.TabIndex = 0;
            btnEmp.Text = "NHÂN VIÊN";
            btnEmp.UseVisualStyleBackColor = true;
            btnEmp.Click += btnEmp_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(288, 15);
            panelContainer.Margin = new Padding(4, 4, 4, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1768, 1342);
            panelContainer.TabIndex = 1;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2279, 1291);
            Controls.Add(panelContainer);
            Controls.Add(panelTab);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AdminMenu";
            Text = "AdminMenu";
            panelTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTab;
        private Button btnEmp;
        private Button button5;
        private Button btnSchedule;
        private Button button3;
        private Button btnAdminDrinks;
        private Button button6;
        private Panel panelContainer;
    }
}