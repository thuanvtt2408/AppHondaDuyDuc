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

        public int StockQuantity { get; set; }
        public decimal ImportPrice { get; set; }
    }
}
