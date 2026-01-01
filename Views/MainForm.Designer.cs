namespace AppHondaDuyDuc.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            gbMenu = new GroupBox();
            btnOrder = new Button();
            btnCustomer = new Button();
            panel1 = new Panel();
            btnKhoPhuTung = new Button();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btnKhoPhuTung);
            gbMenu.Controls.Add(btnOrder);
            gbMenu.Controls.Add(btnCustomer);
            gbMenu.Dock = DockStyle.Left;
            gbMenu.Location = new Point(0, 0);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(180, 450);
            gbMenu.TabIndex = 0;
            gbMenu.TabStop = false;
            gbMenu.Text = "Menu";
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.Location = new Point(3, 67);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(174, 48);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Tạo đơn sửa xe";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Location = new Point(3, 19);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(174, 48);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Quản lý khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(186, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 402);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnKhoPhuTung
            // 
            btnKhoPhuTung.Dock = DockStyle.Top;
            btnKhoPhuTung.Location = new Point(3, 115);
            btnKhoPhuTung.Name = "btnKhoPhuTung";
            btnKhoPhuTung.Size = new Size(174, 48);
            btnKhoPhuTung.TabIndex = 2;
            btnKhoPhuTung.Text = "Kho phụ tùng";
            btnKhoPhuTung.UseVisualStyleBackColor = true;
            btnKhoPhuTung.Click += btnKhoPhuTung_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gbMenu);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOrder;
        private Button btnKhoPhuTung;
    }
}
