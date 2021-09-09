using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace DapperTestSQLite
{
    public record Test1Dto
    {
        public Test1Dto(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; init; }
        public string Name { get; init; }
    }

    public static class Test1Ext
    {
        public static Unit WriteLine(this Test1Dto t)
        {
            Console.WriteLine($"{t.Id} : {t.Name}");
            return Unit();
        }
    }
}