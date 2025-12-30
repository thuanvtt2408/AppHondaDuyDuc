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
    public class StockLogRepository : BaseRepository
    {
        public void Insert(StockLog log)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                INSERT INTO stock_log(part_id, change_qty, reason)
                VALUES (@part, @qty, @reason)
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@part", log.PartId);
            cmd.Parameters.AddWithValue("@qty", log.ChangeQty);
            cmd.Parameters.AddWithValue("@reason", log.Reason);

            cmd.ExecuteNonQuery();
        }
    }
}
