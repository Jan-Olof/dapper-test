using Dapper;
using FuncLib;

namespace DapperTestMySql
{
    internal class Program
    {
        private const string ConnStr = @"Server=localhost;Database=world;Uid=root;Pwd=AfSec722610!;";
        private const string SelectCity = "SELECT ID, Name FROM city WHERE ID = @Id";

        private static void Main(string[] args) =>
            DbServer.MySql
                .Connect(ConnStr, conn => conn.QueryFirst<CityDto>(SelectCity, new { Id = 14 }))
                .WriteLine()
                .ReadLine();
    }
}