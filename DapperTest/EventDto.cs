namespace DapperTest
{
    public record EventDto
    {
        public EventDto(int id, string eventName)
        {
            Id = id;
            EventName = eventName;
        }

        public int Id { get; init; }
        public string EventName { get; init; }
    }
}