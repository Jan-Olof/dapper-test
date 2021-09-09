using Dapper;
using FuncLib;

namespace DapperTestPostgreSql
{
    internal class Program
    {
        private const string ConnStr = @"User ID=afadmin;Password=AfSec722610!;Host=localhost;Port=5432;Database=dvdrental;";
        private const string SelectActor = "SELECT actor_id, first_name, last_name FROM actor WHERE actor_id = @Id";

        private static void Main(string[] args) =>
            DbServer.PostgreSql
                .Connect(ConnStr, conn => conn.QueryFirst<ActorDto>(SelectActor, new { Id = 4 }))
                .WriteLine()
                .ReadLine();
    }
}