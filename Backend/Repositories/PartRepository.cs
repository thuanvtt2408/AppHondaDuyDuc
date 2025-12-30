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
    public class PartRepository : BaseRepository
    {
        public List<Part> GetAll()
        {
            var list = new List<Part>();
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                SELECT id, category_id, name, stock_quantity, import_price
                FROM parts
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Part
                {
                    Id = reader.GetInt32(0),
                    CategoryId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    StockQuantity = reader.GetInt32(3),
                    ImportPrice = reader.GetDecimal(4)
                });
            }
            return list;
        }
    }
}
