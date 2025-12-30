using AppHondaDuyDuc.Backend.Models;
using AppQuanLySuaXe.Backend.Repositories.Base;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySuaXe.Backend.Repositories
{
    public class CustomerRepository : BaseRepository
    {
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                SELECT id, full_name, phone, license_plate, vehicle_type
                FROM customers
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Customer
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Phone = reader.IsDBNull(2) ? null : reader.GetString(2),
                    LicensePlate = reader.GetString(3),
                    VehicleType = reader.GetInt32(4)
                });
            }
            return list;
        }

        public void Insert(Customer c)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                INSERT INTO customers(full_name, phone, license_plate, vehicle_type)
                VALUES (@name, @phone, @plate, @type)
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", c.FullName);
            cmd.Parameters.AddWithValue("@phone", (object?)c.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@plate", c.LicensePlate);
            cmd.Parameters.AddWithValue("@type", c.VehicleType);

            cmd.ExecuteNonQuery();
        }
    }
}
