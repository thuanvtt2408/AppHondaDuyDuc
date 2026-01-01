using AppHondaDuyDuc.Backend.Models;
using AppQuanLySuaXe.Backend.Repositories.Base;
using Npgsql;

namespace AppHondaDuyDuc.Repositories
{
    public class OrderRepository : BaseRepository
    {
        public List<Order> GetAll()
        {
            var list = new List<Order>();

            using var conn = GetConnection();
            conn.Open();

            string sql = @"
                SELECT o.id, c.full_name, o.order_date, o.description,
                       o.total_amount, o.paid_amount, o.debt_amount
                FROM orders o
                JOIN customers c ON o.customer_id = c.id
                ORDER BY o.id DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Order
                {
                    Id = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    OrderDate = reader.GetDateTime(2),
                    Description = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    TotalAmount = reader.GetDecimal(4),
                    PaidAmount = reader.GetDecimal(5),
                    DebtAmount = reader.GetDecimal(6)
                });
            }

            return list;
        }

        public void Insert(Order order)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO orders (customer_id, description, total_amount, paid_amount, debt_amount)
                VALUES (@customer_id, @desc, @total, @paid, @debt)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@customer_id", order.CustomerId);
            cmd.Parameters.AddWithValue("@desc", order.Description ?? "");
            cmd.Parameters.AddWithValue("@total", order.TotalAmount);
            cmd.Parameters.AddWithValue("@paid", order.PaidAmount);
            cmd.Parameters.AddWithValue("@debt", order.DebtAmount);

            cmd.ExecuteNonQuery();
        }
    }
}

