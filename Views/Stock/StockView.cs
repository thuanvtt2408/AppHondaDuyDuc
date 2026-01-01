using AppHondaDuyDuc.Backend.Models;
using AppHondaDuyDuc.Controllers;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppHondaDuyDuc.Views.Stocks
{
    public partial class StockView : UserControl
    {
        private readonly PartController _controller = new();

        public StockView()
        {
            InitializeComponent();
            LoadStockItems();
        }

        private void LoadStockItems()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = _controller.GetAll();
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên vật tư không được để trống");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            if (!decimal.TryParse(txtImportPrice.Text, out decimal importPrice))
            {
                MessageBox.Show("Giá nhập không hợp lệ");
                return;
            }

            if (!decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return;
            }

            var item = new Part
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StockQuantity = qty,
                Unit = txtUnit.Text,
                Location = txtLocation.Text,
                ImportPrice = importPrice,
                SalePrice = salePrice,
                Status = "available"
            };

            _controller.Create(item);
            LoadStockItems();
            ClearForm();
            MessageBox.Show("Thêm vật tư thành công ✅");
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtLocation.Clear();
            txtImportPrice.Clear();
            txtSalePrice.Clear();
        }
    }
}
