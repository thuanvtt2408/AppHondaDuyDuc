namespace AppHondaDuyDuc.Views.Stocks
{
    partial class StockView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStock = new System.Windows.Forms.DataGridView();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();

            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblImportPrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();

            this.panelTop = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // ===== Panel Top: chứa form nhập liệu =====
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 380; // chiều cao cố định
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);

            // Labels
            this.lblName.Text = "Tên vật tư"; this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblDesc.Text = "Mô tả"; this.lblDesc.Location = new System.Drawing.Point(20, 70);
            this.lblQty.Text = "Số lượng"; this.lblQty.Location = new System.Drawing.Point(20, 120);
            this.lblUnit.Text = "Đơn vị"; this.lblUnit.Location = new System.Drawing.Point(20, 170);
            this.lblLocation.Text = "Vị trí"; this.lblLocation.Location = new System.Drawing.Point(20, 220);
            this.lblImportPrice.Text = "Giá nhập"; this.lblImportPrice.Location = new System.Drawing.Point(20, 270);
            this.lblSalePrice.Text = "Giá bán"; this.lblSalePrice.Location = new System.Drawing.Point(20, 320);

            // TextBoxes
            this.txtName.Location = new System.Drawing.Point(150, 15); this.txtName.Size = new System.Drawing.Size(350, 38);
            this.txtDescription.Location = new System.Drawing.Point(150, 65); this.txtDescription.Size = new System.Drawing.Size(350, 38);
            this.txtQuantity.Location = new System.Drawing.Point(150, 115); this.txtQuantity.Size = new System.Drawing.Size(150, 38);
            this.txtUnit.Location = new System.Drawing.Point(150, 165); this.txtUnit.Size = new System.Drawing.Size(150, 38);
            this.txtLocation.Location = new System.Drawing.Point(150, 215); this.txtLocation.Size = new System.Drawing.Size(150, 38);
            this.txtImportPrice.Location = new System.Drawing.Point(150, 265); this.txtImportPrice.Size = new System.Drawing.Size(150, 38);
            this.txtSalePrice.Location = new System.Drawing.Point(150, 315); this.txtSalePrice.Size = new System.Drawing.Size(150, 38);

            // Button
            this.btnAdd.Text = "Thêm vật tư";
            this.btnAdd.Location = new System.Drawing.Point(550, 150);
            this.btnAdd.Size = new System.Drawing.Size(180, 50);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Add controls vào panelTop
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Controls.Add(this.lblDesc);
            this.panelTop.Controls.Add(this.lblQty);
            this.panelTop.Controls.Add(this.lblUnit);
            this.panelTop.Controls.Add(this.lblLocation);
            this.panelTop.Controls.Add(this.lblImportPrice);
            this.panelTop.Controls.Add(this.lblSalePrice);

            this.panelTop.Controls.Add(this.txtName);
            this.panelTop.Controls.Add(this.txtDescription);
            this.panelTop.Controls.Add(this.txtQuantity);
            this.panelTop.Controls.Add(this.txtUnit);
            this.panelTop.Controls.Add(this.txtLocation);
            this.panelTop.Controls.Add(this.txtImportPrice);
            this.panelTop.Controls.Add(this.txtSalePrice);

            this.panelTop.Controls.Add(this.btnAdd);

            // ===== DataGridView =====
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.RowTemplate.Height = 35; // dòng cao hơn
            this.dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvStock.Margin = new System.Windows.Forms.Padding(10);

            // ===== StockView =====
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panelTop);

            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(1400, 850);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dgvStock;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.Label lblSalePrice;
    }
}
