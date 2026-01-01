using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHondaDuyDuc.Backend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string LicensePlate { get; set; }
        public int VehicleType { get; set; } // 1 = Xe máy, 2 = Ô tô
        public DateTime CreatedAt { get; set; }
    }
}
