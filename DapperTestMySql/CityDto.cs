using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace DapperTestMySql
{
    public record CityDto
    {
        public CityDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; init; }
        public string Name { get; init; }
    }

    public static class CityExt
    {
        public static Unit WriteLine(this CityDto c)
        {
            Console.WriteLine(c.Id + " : " + c.Name);
            return Unit();
        }
    }
}