namespace CFPOS
{
    partial class AdminRevenue
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
            dgvOrders = new DataGridView();
            btnReset = new Button();
            btnFilter = new Button();
            lbToDate = new Label();
            lbFromDate = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            button1 = new Button();
            lblTable = new Label();
            label1 = new Label();
            lblRevenue = new Label();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(88, 78);
            dgvOrders.Margin = new Padding(4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new Size(1130, 358);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellContentDoubleClick += dgvOrders_CellContentDoubleClick;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(305, 590);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 60);
            btnReset.TabIndex = 36;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(144, 590);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(130, 60);
            btnFilter.TabIndex = 33;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new Point(70, 541);
            lbToDate.Margin = new Padding(2, 0, 2, 0);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new Size(30, 25);
            lbToDate.TabIndex = 32;
            lbToDate.Text = "To";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new Point(59, 485);
            lbFromDate.Margin = new Padding(2, 0, 2, 0);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new Size(54, 25);
            lbFromDate.TabIndex = 31;
            lbFromDate.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(144, 479);
            dtpFrom.Margin = new Padding(4);
            dtpFrom.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(312, 31);
            dtpFrom.TabIndex = 37;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(144, 535);
            dtpTo.Margin = new Padding(4);
            dtpTo.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(312, 31);
            dtpTo.TabIndex = 38;
            dtpTo.Value = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // button1
            // 
            button1.Location = new Point(4, 34);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 39;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Location = new Point(225, 39);
            lblTable.Margin = new Padding(4, 0, 4, 0);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(59, 25);
            lblTable.TabIndex = 40;
            lblTable.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(778, 474);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 41;
            label1.Text = "Doanh thu: ";
            label1.Click += label1_Click;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRevenue.Location = new Point(966, 474);
            lblRevenue.Margin = new Padding(4, 0, 4, 0);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(121, 31);
            lblRevenue.TabIndex = 42;
            lblRevenue.Text = "Doanh thu";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(1159, 39);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 25);
            lblMessage.TabIndex = 43;
            lblMessage.Text = "label1";
            // 
            // AdminRevenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(lblRevenue);
            Controls.Add(label1);
            Controls.Add(lblTable);
            Controls.Add(button1);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(lbToDate);
            Controls.Add(lbFromDate);
            Controls.Add(dgvOrders);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AdminRevenue";
            Size = new Size(1301, 766);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnReset;
        private Button btnFilter;
        private Label lbToDate;
        private Label lbFromDate;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button button1;
        private Label lblTable;
        private Label label1;
        private Label lblRevenue;
        private Label lblMessage;
    }
}
