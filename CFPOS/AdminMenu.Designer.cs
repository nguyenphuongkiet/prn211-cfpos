﻿namespace CFPOS
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
            button1 = new Button();
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
            panelTab.Controls.Add(button1);
            panelTab.Location = new Point(7, 8);
            panelTab.Margin = new Padding(2, 1, 2, 1);
            panelTab.Name = "panelTab";
            panelTab.Size = new Size(151, 583);
            panelTab.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(17, 495);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(115, 73);
            button6.TabIndex = 5;
            button6.Text = "ĐĂNG XUẤT";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(17, 404);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(115, 73);
            button5.TabIndex = 4;
            button5.Text = "IN PROGRESS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(17, 312);
            btnSchedule.Margin = new Padding(2, 1, 2, 1);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(115, 73);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "CA TRỰC";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // button3
            // 
            button3.Location = new Point(17, 219);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(115, 73);
            button3.TabIndex = 2;
            button3.Text = "DOANH THU";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAdminDrinks
            // 
            btnAdminDrinks.Location = new Point(17, 119);
            btnAdminDrinks.Margin = new Padding(2, 1, 2, 1);
            btnAdminDrinks.Name = "btnAdminDrinks";
            btnAdminDrinks.Size = new Size(115, 73);
            btnAdminDrinks.TabIndex = 1;
            btnAdminDrinks.Text = "ĐỒ UỐNG";
            btnAdminDrinks.UseVisualStyleBackColor = true;
            btnAdminDrinks.Click += btnAdminDrinks_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 19);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(115, 73);
            button1.TabIndex = 0;
            button1.Text = "NHÂN VIÊN";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(177, 9);
            panelContainer.Margin = new Padding(2, 3, 2, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1088, 839);
            panelContainer.TabIndex = 1;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 807);
            Controls.Add(panelContainer);
            Controls.Add(panelTab);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            panelTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTab;
        private Button button1;
        private Button button5;
        private Button btnSchedule;
        private Button button3;
        private Button btnAdminDrinks;
        private Button button6;
        private Panel panelContainer;
    }
}