using AppHondaDuyDuc.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppHondaDuyDuc.Controllers
{
    public class PartController
    {
        private readonly List<Part> _items = new();

        // Lấy tất cả vật tư
        public List<Part> GetAll()
        {
            return _items;
        }

        // Thêm vật tư mới
        public void Create(Part item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);

            // Ghi log nhập kho
            AddStockLog(item.Id, item.StockQuantity, "import", "Nhập kho ban đầu");
        }

        // Cập nhật vật tư
        public void Update(Part item)
        {
            var existing = _items.FirstOrDefault(x => x.Id == item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Description = item.Description;
                existing.StockQuantity = item.StockQuantity;
                existing.Unit = item.Unit;
                existing.Location = item.Location;
                existing.ImportPrice = item.ImportPrice;
                existing.SalePrice = item.SalePrice;
                existing.Status = item.Status;
            }
        }

        // Xóa vật tư
        public void Delete(int id)
        {
            _items.RemoveAll(x => x.Id == id);
        }

        // Nhập kho / xuất kho
        public void ChangeStock(int partId, int quantity, string reason, string type)
        {
            var item = _items.FirstOrDefault(x => x.Id == partId);
            if (item != null)
            {
                item.StockQuantity += quantity;

                // Nếu số lượng <=0 thì đổi trạng thái
                if (item.StockQuantity <= 0)
                {
                    item.Status = "out_of_stock";
                    item.StockQuantity = 0;
                }

                AddStockLog(partId, quantity, type, reason);
            }
        }

        // Log nhập/xuất
        private void AddStockLog(int partId, int changeQty, string type, string reason)
        {
            // Tạm thời in ra console, khi kết nối DB sẽ insert vào bảng stock_log
            Console.WriteLine($"LOG: PartId={partId}, ChangeQty={changeQty}, Type={type}, Reason={reason}, Time={DateTime.Now}");
        }
    }
}
