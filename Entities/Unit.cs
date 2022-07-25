namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Unit
    {
        MINUTE = 0,
        HOUR = 1,
        DAY = 2,
        YEAR = 3
    }
}