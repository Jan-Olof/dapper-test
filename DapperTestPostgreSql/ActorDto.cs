using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace DapperTestPostgreSql
{
    public record ActorDto
    {
        public ActorDto(int actor_id, string first_name, string last_name)
        {
            Id = actor_id;
            FirstName = first_name;
            LastName = last_name;
        }

        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public static class ActorExt
    {
        public static Unit WriteLine(this ActorDto a)
        {
            Console.WriteLine($"{a.Id} : {a.FirstName} {a.LastName}");
            return Unit();
        }
    }
}