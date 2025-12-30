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
    public class PartCategoryRepository : BaseRepository
    {
        public List<PartCategory> GetAll()
        {
            var list = new List<PartCategory>();
            using var conn = GetConnection();
            conn.Open();

            string sql = "SELECT id, name FROM part_categories";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new PartCategory
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }
            return list;
        }
    }
}
