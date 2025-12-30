using AppHondaDuyDuc.Backend.Models;
using AppQuanLySuaXe.Backend.Repositories.Base;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHondaDuyDuc.Backend.Repositories
{
    public class VehicleTypeRepository : BaseRepository
    {
        public List<VehicleType> GetAll()
        {
            var list = new List<VehicleType>();
            using var conn = GetConnection();
            conn.Open();

            string sql = "SELECT id, name FROM vehicle_type";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new VehicleType
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }
            return list;
        }
    }
}
