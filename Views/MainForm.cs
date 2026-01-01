using AppHondaDuyDuc.Views.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHondaDuyDuc.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // mở full màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            gbMenu.Dock = DockStyle.Left;
            gbMenu.Width = 150;

            panel1.Dock = DockStyle.Fill;
        }

        private void LoadView(UserControl view)
        {
            panel1.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadView(new CustomerView());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoadView(new Orders.OrderView());
        }

        private void btnKhoPhuTung_Click(object sender, EventArgs e)
        {
            LoadView(new Stocks.StockView());
        }
    }
}
