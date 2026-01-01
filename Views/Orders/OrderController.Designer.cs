namespace AppHondaDuyDuc.Views.Orders
{
    partial class OrderView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvOrders = new DataGridView();
            cboCustomer = new ComboBox();
            txtTotal = new TextBox();
            txtPaid = new TextBox();
            txtDescription = new TextBox();
            btnCreate = new Button();
            lblCustomer = new Label();
            lblTotal = new Label();
            lblPaid = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Font = new Font("Segoe UI", 12F);
            dgvOrders.Location = new Point(20, 260);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(1310, 589);
            dgvOrders.TabIndex = 9;
            // 
            // cboCustomer
            // 
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.Font = new Font("Segoe UI", 13F);
            cboCustomer.Location = new Point(180, 30);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(420, 31);
            cboCustomer.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 13F);
            txtTotal.Location = new Point(180, 85);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(420, 31);
            txtTotal.TabIndex = 5;
            // 
            // txtPaid
            // 
            txtPaid.Font = new Font("Segoe UI", 13F);
            txtPaid.Location = new Point(180, 140);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(420, 31);
            txtPaid.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 13F);
            txtDescription.Location = new Point(180, 195);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(420, 31);
            txtDescription.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCreate.Location = new Point(650, 110);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 55);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Tạo đơn";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCustomer.Location = new Point(30, 35);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(113, 25);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Khách hàng";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotal.Location = new Point(30, 90);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng tiền";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPaid.Location = new Point(30, 145);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(64, 25);
            lblPaid.TabIndex = 2;
            lblPaid.Text = "Đã trả";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDescription.Location = new Point(30, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(62, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Mô tả";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCustomer);
            Controls.Add(lblTotal);
            Controls.Add(lblPaid);
            Controls.Add(lblDescription);
            Controls.Add(cboCustomer);
            Controls.Add(txtTotal);
            Controls.Add(txtPaid);
            Controls.Add(txtDescription);
            Controls.Add(btnCreate);
            Controls.Add(dgvOrders);
            Font = new Font("Segoe UI", 12F);
            Name = "OrderView";
            Size = new Size(1360, 879);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblDescription;
    }
}
