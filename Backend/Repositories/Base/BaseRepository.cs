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
            "Host=localhost;Port=2222;Database=AppQuanLySuaXe;Username=postgres;Password=12345";

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
