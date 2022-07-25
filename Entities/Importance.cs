namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Importance
    {
        LOW = 0,
        MEDIUM = 1,
        HIGH = 2
    }
}