using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using Npgsql;

namespace FuncLib
{
    public static class ConnectionHelper
    {
        public static T Connect<T>(this string connString, Func<IDbConnection, T> f)
        {
            using var conn = new SqlConnection(connString);
            conn.Open();
            return f(conn);
        }

        public static T Connect<T>(this DbServer server, string connString, Func<IDbConnection, T> f)
        {
            using var conn = GetDbConnection(server, connString);
            conn.Open();
            return f(conn);
        }

        private static DbConnection GetDbConnection(DbServer server, string connString) =>
            server switch
            {
                DbServer.SqlServer => new SqlConnection(connString),
                DbServer.SqLite => new SqliteConnection(connString),
                DbServer.MySql => new MySqlConnection(connString),
                DbServer.PostgreSql => new NpgsqlConnection(connString),
                _ => throw new ArgumentOutOfRangeException(nameof(server))
            };
    }
}