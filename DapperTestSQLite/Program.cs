using Dapper;
using FuncLib;

namespace DapperTestSQLite
{
    internal class Program
    {
        private const string ConnStr = @"Data Source=C:\sqlite\test.db;";
        private const string SelectTest1 = "SELECT Id, Name FROM test1 WHERE Id = @Id";

        private static void Main(string[] args) =>
            DbServer.SqLite
                .Connect(ConnStr, conn => conn.QueryFirst<Test1Dto>(SelectTest1, new { Id = 2 }))
                .WriteLine()
                .ReadLine();
    }
}