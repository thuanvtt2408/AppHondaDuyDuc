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
    }
}
