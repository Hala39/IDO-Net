namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Unit
    {
        minute = 0,
        hour = 1,
        day = 2,
        year = 3
    }
}