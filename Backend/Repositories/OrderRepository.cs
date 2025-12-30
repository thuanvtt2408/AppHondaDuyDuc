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
    public class OrderRepository : BaseRepository
    {
        public int Insert(Order o)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = """
                INSERT INTO orders(customer_id, description, total_amount, paid_amount, debt_amount)
                VALUES (@customer, @desc, @total, @paid, @debt)
                RETURNING id
            """;

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@customer", o.CustomerId);
            cmd.Parameters.AddWithValue("@desc", (object?)o.Description ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@total", o.TotalAmount);
            cmd.Parameters.AddWithValue("@paid", o.PaidAmount);
            cmd.Parameters.AddWithValue("@debt", o.DebtAmount);

            return (int)cmd.ExecuteScalar();
        }
    }
}
