
namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        toDo = 0,
        doing = 1,
        done = 2
    }
}