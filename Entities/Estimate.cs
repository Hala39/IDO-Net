namespace API.Entities
{
    public class Estimate
    {
        public int Number { get; set; }
        public Unit Unit { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Unit 
    {
        minute = 0,
        hour = 1,
        day = 2,
        year = 3
    }
}