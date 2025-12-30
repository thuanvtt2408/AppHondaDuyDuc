using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace AppQuanLySuaXe.Backend.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected readonly string _connectionString =
            "Host=localhost;Port=5432;Database=honda_db;Username=postgres;Password=123456";

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
