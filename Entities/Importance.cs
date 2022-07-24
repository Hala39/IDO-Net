namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Importance
    {
        low = 0,
        medium = 1,
        high = 2
    }
}