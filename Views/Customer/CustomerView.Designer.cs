namespace AppHondaDuyDuc.Views.Customer
{
    partial class CustomerView
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelTop;
        private Panel panelContent;
        private DataGridView dataGridView1;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            flp = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelContent = new Panel();
            dataGridView1 = new DataGridView();
            panelTop.SuspendLayout();
            flp.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Gainsboro;
            panelTop.Controls.Add(flp);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1360, 60);
            panelTop.TabIndex = 1;
            // 
            // flp
            // 
            flp.Controls.Add(btnThem);
            flp.Controls.Add(btnSua);
            flp.Controls.Add(btnXoa);
            flp.Controls.Add(btnLamMoi);
            flp.Dock = DockStyle.Fill;
            flp.Location = new Point(10, 10);
            flp.Name = "flp";
            flp.Size = new Size(1340, 40);
            flp.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 30);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(99, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Sửa";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(195, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑 Xóa";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(291, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 30);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "🔄 Làm mới";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(10);
            panelContent.Size = new Size(1360, 841);
            panelContent.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1340, 821);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "CustomerView";
            Size = new Size(1360, 901);
            panelTop.ResumeLayout(false);
            flp.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp;
    }
}
