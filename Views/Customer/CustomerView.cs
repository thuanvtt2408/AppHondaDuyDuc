using AppHondaDuyDuc.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppHondaDuyDuc.Controllers;

namespace AppHondaDuyDuc.Views.Customer
{
    public partial class CustomerView : UserControl
    {
        private readonly CustomerController _controller = new();

        public CustomerView()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _controller.GetAll();
        }
    }
}

