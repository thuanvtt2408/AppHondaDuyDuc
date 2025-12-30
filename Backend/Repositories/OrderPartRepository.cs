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
    public class OrderPartRepository : BaseRepository
    {
        public void Insert(OrderPart op)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                INSERT INTO order_parts(order_id, part_id, quantity, unit_price)
                VALUES (@order, @part, @qty, @price)
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@order", op.OrderId);
            cmd.Parameters.AddWithValue("@part", op.PartId);
            cmd.Parameters.AddWithValue("@qty", op.Quantity);
            cmd.Parameters.AddWithValue("@price", op.UnitPrice);

            cmd.ExecuteNonQuery();
        }
    }
}
