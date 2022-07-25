
namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        TODO = 0,
        DOING = 1,
        DONE = 2
    }
}