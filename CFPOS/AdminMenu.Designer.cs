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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(6, 6);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 437);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 14);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(101, 55);
            button1.TabIndex = 0;
            button1.Text = "NHÂN VIÊN";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(161, 46);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 397);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(15, 89);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(101, 55);
            button2.TabIndex = 1;
            button2.Text = "ĐỒ UỐNG";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(15, 164);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(101, 55);
            button3.TabIndex = 2;
            button3.Text = "DOANH THU";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(15, 234);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(101, 55);
            button4.TabIndex = 3;
            button4.Text = "CA TRỰC";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(15, 303);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(101, 55);
            button5.TabIndex = 4;
            button5.Text = "IN PROGRESS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(15, 371);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(101, 55);
            button6.TabIndex = 5;
            button6.Text = "ĐĂNG XUẤT";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(161, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(671, 32);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 457);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Panel panel3;
        private Label label1;
    }
}