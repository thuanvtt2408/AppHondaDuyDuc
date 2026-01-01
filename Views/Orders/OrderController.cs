using AppHondaDuyDuc.Controllers;
using AppHondaDuyDuc.Backend.Models;
using System;
using System.Windows.Forms;

namespace AppHondaDuyDuc.Views.Orders
{
    public partial class OrderView : UserControl
    {
        private readonly OrderController _controller = new();

        public OrderView()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = _controller.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue == null ||
                !int.TryParse(cboCustomer.SelectedValue.ToString(), out int customerId))
            {
                MessageBox.Show("Chọn khách hàng hợp lệ");
                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total) ||
                !decimal.TryParse(txtPaid.Text, out decimal paid))
            {
                MessageBox.Show("Số tiền không hợp lệ");
                return;
            }

            var order = new Order
            {
                CustomerId = customerId,
                Description = txtDescription.Text,
                TotalAmount = total,
                PaidAmount = paid,
                DebtAmount = total - paid,
                OrderDate = DateTime.Now
            };

            _controller.Create(order);
            LoadOrders();
            MessageBox.Show("Tạo đơn thành công ✅");
        }
    }
}
