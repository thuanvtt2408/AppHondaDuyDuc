using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHondaDuyDuc.Backend.Models
{
    public class Part
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }   // Thêm dòng này
        public int StockQuantity { get; set; }
        public string Unit { get; set; }          // Thêm dòng này
        public string Location { get; set; }      // Thêm dòng này
        public decimal ImportPrice { get; set; }
        public decimal SalePrice { get; set; }    // Thêm dòng này
        public string Status { get; set; }        // Thêm dòng này
    }
}
