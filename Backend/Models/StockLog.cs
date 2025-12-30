using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHondaDuyDuc.Backend.Models
{
    public class StockLog
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int ChangeQty { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
