using Dapper;
using FuncLib;
using LaYumba.Functional;

namespace DapperTest
{
    internal class Program
    {
        private const string ConnStr = @"Data Source=SE-5CD9500LTM\SQL2019;Initial Catalog=DapperExample;Integrated Security=SSPI";
        private const string selectEvents = "SELECT Id, EventName FROM Event";

        private static void Main(string[] args) =>
            DbServer.SqlServer
                .Connect(ConnStr, c => c.Query<EventDto>(selectEvents))
                .ForEach(e => ($"{e.Id} : {e.EventName}").WriteLine())
                .ReadLine();

        /*
        private static void Main(string[] args)
        {
            var connectionString = @"Data Source=SE-5CD9500LTM\SQL2019;Initial Catalog=DapperExample;Integrated Security=SSPI";
            using var connection = new SqlConnection(connectionString);

            int eventId = 3;
            var myEvent = connection.QueryFirst<EventDto>("SELECT Id, EventName FROM Event WHERE Id = @Id", new { Id = eventId });
            Console.WriteLine(myEvent.Id + " : " + myEvent.EventName);
            Console.ReadLine();
        }

       private static void Main(string[] args)
       {
           var connStr = @"Data Source=SE-5CD9500LTM\SQL2019;Initial Catalog=DapperExample;Integrated Security=SSPI";
           using var connection = new SqlConnection(connStr);

           var allEvents = connection.Query<EventDto>("SELECT Id, EventName FROM Event");
           foreach (var myEvent in allEvents)
           {
               Console.WriteLine(myEvent.Id + " : " + myEvent.EventName);
           }
           Console.ReadLine();
       }
       */
    }
}